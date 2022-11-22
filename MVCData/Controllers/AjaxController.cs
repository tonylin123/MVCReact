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

    }
}
