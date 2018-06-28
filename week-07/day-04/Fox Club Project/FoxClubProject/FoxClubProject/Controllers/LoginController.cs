using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FoxClubProject.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult PostLoginInfo()
        {
            return RedirectToAction("Login");
        }
    }
}