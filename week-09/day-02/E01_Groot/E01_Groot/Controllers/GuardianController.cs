using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace E01_Groot.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Groot(string message)
        {
            return (message == "somemessage") ?
                Json(new { received = message, translated = "I am Groot!" }) :
                Json(new { error = "I am Groot!" });
        }
    }
}
