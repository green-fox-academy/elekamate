using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClubProject.Models;
using FoxClubProject.Services;

namespace FoxClubProject.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private ILoginService loginService;

        public HomeController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return View(loginService.GetActualFox());
        }
    }
}
