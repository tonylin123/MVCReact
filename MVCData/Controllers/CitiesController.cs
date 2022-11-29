using Microsoft.AspNetCore.Mvc;
using MVCData.ViewModels;
using MVCData.Models;
using MVCData.Data;
using Microsoft.EntityFrameworkCore;


namespace MVCData.Controllers
{
    public class CitiesController : Controller
    {
        public CitiesController(ApplicationDBContext database)
        {
            Database = database;
        }


        private readonly ApplicationDBContext Database;

        public IActionResult Index()
        {
            CitiesViewModel cities = new()
            {
                List = Database.Cities.Include(p => p.Country).ToList()
            };

            return View(cities);
        }
    }
}
