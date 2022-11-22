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


        public IActionResult GetPeople()
        {
            PeopleViewModel viewModel = PeopleModel.List();
            return View("_GetDetails", viewModel);
        }

        [HttpPost]
        public IActionResult DeletePerson(string id)
        {
            var personToDelete = PeopleData.List.FirstOrDefault(p => p.Id == id);

            if (personToDelete != null)
            {
                PeopleData.List.Remove(personToDelete);
            }

            return RedirectToAction("GetPeople");
       
        }
        [HttpPost]
        public IActionResult GetDetails(string id)
        {
            Person person = PeopleData.List.FirstOrDefault(x => x.Id == id);
            if (person == null)
            {
                ViewBag.ERROR = "Person not found";
            }
            return PartialView("_personPartial", person);
        }


    }



}
