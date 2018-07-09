using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using E01_Frontend.Models;

namespace E01_Frontend.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet(" ")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling(int? input)
        {
            return (input is null) ?
                Json(new { error = "Please provide an input!" }) :
                Json(new { received = input, result = input * 2 });
        }

        [HttpGet("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name is null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title is null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }
    }
}
