using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello index.");
        }

        [Route("hello")]
        public IActionResult Hello()
        {
            return Content("Hello world!");
        }
    }
}