using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClubProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClubProject.Controllers
{
    public class LoginController : Controller
    {
        private ILoginService loginService;

        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult PostLoginInfo(string name)
        {


            return RedirectToAction("Login");
        }
    }
}