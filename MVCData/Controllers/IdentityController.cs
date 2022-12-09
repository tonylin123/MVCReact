using MVCData.Data;
using MVCData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCData.ViewModels;

namespace MVCData.Controllers
{
    [Authorize(Roles ="Admin")]
    public class IdentityController : Controller
    {
        readonly RoleManager<IdentityRole> _roleManager;
        readonly UserManager<ApplicationUser> _userManager;

        public IdentityController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
               
        public IActionResult ShowAllUsers()
        {
            return View(_userManager.Users);
        }
        public IActionResult ShowAllRoles()
        {
            return View(_roleManager.Roles);
        }
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);
            return RedirectToAction("ShowAllRoles");
        }
        public async Task<IActionResult> DeleteRole(string id)
        {
            var roleToDelete = await _roleManager.FindByIdAsync(id);
            if(roleToDelete != null)
            {
                await _roleManager.DeleteAsync(roleToDelete);
            }
            return RedirectToAction("ShowAllRoles");
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            var userToDelete = await _userManager.FindByIdAsync(id);

            if(userToDelete != null)
            {
                await _userManager.DeleteAsync(userToDelete);
            }
            return RedirectToAction("ShowAllUsers");
        }
        public async Task<IActionResult> ShowUserRoles(string id)
        {
            UserRolesViewModel vm = new UserRolesViewModel();
            var user = await _userManager.FindByIdAsync(id);

            var assignedRoles = new List<string>(await _userManager.GetRolesAsync(user));

            vm.UserId = id;
            vm.Name = $"{user.FirstName} {user.LastName}";
            vm.Roles.AddRange(assignedRoles);

            return View(vm);
        }
        public async Task<IActionResult> AddRoleToUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            ViewBag.UserId = userId;
            ViewBag.Name = $"{user.FirstName} {user.LastName}";
            ViewBag.Roles = new SelectList(_roleManager.Roles, "Name", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoleToUser(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.AddToRoleAsync(user, roleName);

            return RedirectToAction("ShowUserRoles", new {id =userId});
        }

        

        public async Task<IActionResult> RemoveRoleFromUser(string roleName, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.RemoveFromRoleAsync(user, roleName);

            return RedirectToAction("ShowUserRoles", new { id = userId });
        }

    }
}
