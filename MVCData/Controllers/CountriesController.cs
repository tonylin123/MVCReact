using Microsoft.AspNetCore.Mvc;
using MVCData.ViewModels;
using MVCData.Models;
using MVCData.Data;
using Microsoft.EntityFrameworkCore;
using MVCData.ViewModels;

namespace MVCData.Controllers
{
    public class CountriesController : Controller
    {
        public CountriesController(ApplicationDBContext database)
        {
            Database = database;
        }


        private readonly ApplicationDBContext Database;

        public IActionResult Index()
        {
            CountriesViewModel countries = new()
            {
                List = Database.Countries.ToList()
            };

            return View(countries);
        }
    }
}
