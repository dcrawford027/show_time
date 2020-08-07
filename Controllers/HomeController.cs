using System;
using Microsoft.AspNetCore.Mvc;

namespace time_display.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime datetime = DateTime.Now;
            ViewBag.Time = datetime;
            return View("Index");
        }
    }
}