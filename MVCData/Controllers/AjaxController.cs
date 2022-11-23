using MVCData.Models;
using Microsoft.AspNetCore.Mvc;
using MVCData.ViewModels;

namespace MVCData.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }


        public IActionResult PeopleList()
        {
            PeopleViewModel viewModel = PeopleModel.List();
            return View("_PeopleList", viewModel);
        }

        [HttpPost]
        public IActionResult DeletePerson(string id)
        {
            
            var personToDelete = PeopleData.List.FirstOrDefault(p => p.Id == id);

            if (personToDelete != null)
            {
                PeopleData.List.Remove(personToDelete);
                return Json(id + " was deleted, status: " + StatusCode(200).StatusCode);
            }

            return Json("Error could not delete, status: " + StatusCode(400).StatusCode);

        }
        [HttpPost]
        public IActionResult GetDetails(string id)
        {
            
            Person person = PeopleData.List.FirstOrDefault(x => x.Id == id);

            if (person == null)
            {
                ViewBag.ERROR = "Person not found";
            }
            return View("_personPartial", person);
        }


    }



}
