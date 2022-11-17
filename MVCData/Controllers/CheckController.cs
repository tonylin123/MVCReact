using MVCData.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVCData.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CheckAge()
        {
            return View(); 
        }

       [HttpPost]
        public IActionResult CheckAge(int input)
        {
            //if (input >= 18)
            //{
            //    ViewBag.Result = "You are old enough to vote!";
            //}
            //else
            //{
            //    ViewBag.Result = "You are NOT old enough to vote!";
            //}s
            ViewBag.Result = CheckModel.CheckAge(input);

            return View();
        }

        public IActionResult SetSession()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetSession(string input)
        {
            if(input !=null)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddMinutes(5);

                HttpContext.Response.Cookies.Append("Cookie", input, options);
                HttpContext.Session.SetString("Session", input);
                ViewBag.Message = "Session and cookies has been set!";
            }
            return View(); 
        }

        public IActionResult GetSession()
        {
            ViewBag.Session = HttpContext.Session.GetString("Session");
            ViewBag.Cookie = HttpContext.Request.Cookies["Cookie"];
            return View();
        }
    }
}
