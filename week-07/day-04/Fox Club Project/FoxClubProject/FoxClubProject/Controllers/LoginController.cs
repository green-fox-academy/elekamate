using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClubProject.Models;
using FoxClubProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClubProject.Controllers
{
    [Route("Login")]
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
            return View(loginService);
        }

        [HttpPost]
        [Route("/PostLoginInfo")]
        public IActionResult PostLoginInfo(string name)
        {
            if (loginService.Validation(name))
            {
                return RedirectToAction("../Home/Index");
            }
            else
            {
                loginService.AddFox(new Fox(name));
                return RedirectToAction("Login");
            }
        }
    }
}