using Microsoft.AspNetCore.Mvc;
using MVCData.ViewModels;
using MVCData.Models;

namespace MVCData.Controllers
{
    public class PeopleSearchController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            PCViewModels viewModels = new()
            {
                People = PeopleModel.List()
            };

            return View(viewModels);
        }


        [HttpPost]
        public IActionResult Search(string search)
        {
            PCViewModels viewModels = new()
            {
                People = PeopleModel.Search(search)
            };

            return View("Index", viewModels);
        }


        [HttpPost]
        public IActionResult CreatePerson(CreatePersonViewModel person)
        {
            PCViewModels viewModels = new();

            if (ModelState.IsValid)
            {
                viewModels.People = PeopleModel.CreatePerson(person);
            }
            else
            {
               
                viewModels.CreatePerson.Name = person.Name;
                viewModels.CreatePerson.Phone = person.Phone;
                viewModels.CreatePerson.City = person.City;
            }

            return View("Index", viewModels);
        }


        [HttpGet]
        public IActionResult DeletePerson(string name)
        {
            PCViewModels viewModels = new()
           {
               People = PeopleModel.DeletePerson(name)
           };

           return View("Index", viewModels);
        }
        //public IActionResult Delete(string name)
        //{
        //    var personToDelete = PersonViewModel.listOfPeople.FirstOrDefault(x => x.Name == name);
        //    if (personToDelete != null)
        //    {
        //        PersonViewModel.listOfPeople.Remove(personToDelete);
        //    }

        //    return RedirectToAction("Index");
        //}
    }
}