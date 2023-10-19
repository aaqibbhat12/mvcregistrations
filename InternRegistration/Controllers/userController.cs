using InternRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InternRegistration.Controllers
{
    public class userController : Controller
    {
        

    
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]


        [HttpGet]
        public IActionResult Login()
        {
            return View();  
        }
    

    }
}
