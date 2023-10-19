using InternRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InternRegistration.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}