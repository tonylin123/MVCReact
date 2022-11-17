using MVCData.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVCData.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetDetails(string id)
        {
            Person person = PersonViewModel.listOfPeople.FirstOrDefault(x => x.Id == id);

            return PartialView("_personPartial", person);
        }
    }
}
