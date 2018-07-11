using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E01_PC4.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace E01_PC4.Controllers
{
    public class ValuesController : Controller
    {
        [HttpGet("/")]
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

        [HttpPost("arrays")]
        public IActionResult Arrays([FromBody]InputJasonArray1 jsonInputObj)
        {
            if (jsonInputObj.What is null || jsonInputObj.Numbers is null)
            {
                return Json(new { error = "please provide what to do with the numbers!" });
            }
            else
            {
                int resultNumber = 0;
                foreach (int xNumber in jsonInputObj.Numbers)
                {
                    resultNumber += xNumber;
                }
                return Json(new { result = resultNumber });
            }
        }
    }
}
