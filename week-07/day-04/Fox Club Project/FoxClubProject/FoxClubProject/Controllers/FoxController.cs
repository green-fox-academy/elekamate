using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClubProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClubProject.Controllers
{
    [Route("Fox")]
    public class FoxController : Controller
    {
        private IFoxService foxService;

        public FoxController(IFoxService foxService)
        {
            this.foxService = foxService;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return View(foxService.GetUserFox());
        }
    }
}
