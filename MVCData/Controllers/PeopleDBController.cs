using Microsoft.AspNetCore.Mvc;
using MVCData.ViewModels;
using MVCData.Models;
using MVCData.Data;
using Microsoft.EntityFrameworkCore;

namespace MVCData.Controllers
{
    public class PeopleDBController : Controller
    {

        public PeopleDBController(ApplicationDBContext database)
    {
        Database = database;
    }


    private readonly ApplicationDBContext Database;


    [HttpGet]
    public IActionResult Index()
    {
        ViewModelsContainer viewModels = new()
        {
            People = new PeopleViewModel()
            {
                List = Database.People.ToList()
            }
        };

        return View(viewModels);
    }


    [HttpPost]
    public IActionResult Search(string search)
    {
        ViewModelsContainer viewModels = new()
        {
            People = new PeopleViewModel()
            {
                Search = search,
                List = PeopleDBModel.Search(Database.People.ToList(), search)
            }
        };

        return View("Index", viewModels);
    }


    [HttpPost]
    public IActionResult CreatePerson(Person person)
    {
        ViewModelsContainer viewModels = new()
        {
            People = new PeopleViewModel(),
            CreatePerson = new CreatePersonViewModel()
        };
            ModelState.Remove("Id");
            if (ModelState.IsValid)
        {
             person.Id = Guid.NewGuid().ToString();
               
            Database.People.Add(person);
            Database.SaveChanges();
        }
        else
        {
            
            viewModels.CreatePerson.Name = person.Name;
            viewModels.CreatePerson.Phone = person.Phone;
            viewModels.CreatePerson.City = person.City;
        }

        viewModels.People.List = Database.People.ToList();
        return View("Index", viewModels);
    }


    [HttpGet]
    public IActionResult DeletePerson(string name)
    {
            var personToDelete = Database.People.FirstOrDefault(p => p.Name == name);
            if (personToDelete != null)
        {
                Database.People.Remove(personToDelete);
                Database.SaveChanges();
            }

        ViewModelsContainer viewModels = new()
        {
            People = new PeopleViewModel()
            {
                List = Database.People.ToList(),
            }
        };

        return View("Index", viewModels);
    }
}
}