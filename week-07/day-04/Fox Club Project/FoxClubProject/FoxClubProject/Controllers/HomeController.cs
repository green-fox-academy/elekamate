using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClubProject.Models;

namespace FoxClubProject.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
