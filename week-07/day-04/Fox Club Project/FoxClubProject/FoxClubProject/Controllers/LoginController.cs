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
        private IFoxService foxService;

        public LoginController(ILoginService loginService, IFoxService foxService)
        {
            this.loginService = loginService;
            this.foxService = foxService;
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
                Fox userFox = new Fox(name);
                foxService.SetUserFox(userFox);
                foxService.GetUserFox().TrickAdd(foxService.GetTricks()[0]);
                foxService.GetUserFox().TrickAdd(foxService.GetTricks()[1]);
                return RedirectToAction("index", "fox");
            }
            else
            {
                loginService.AddFox(new Fox(name));
                return RedirectToAction("Login");
            }
        }
    }
}
