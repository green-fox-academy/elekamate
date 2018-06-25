using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace HelloWorld.Controllers
{
    
    public class RESTController : Controller
    {
        private static int actualGreetingId=0;

        public static List<Greeting> greetings = new List<Greeting>()
        {
            new Greeting {Id=0, Content="Hello"},
            new Greeting {Id=1, Content="Szia"}
        };

        public IActionResult Index()
        {
            return Content("testapi");
        }

        [Route("api/greeting")]
        public IActionResult Greeting(string name)
        {
            if (actualGreetingId+1== greetings.Count)
            {
                actualGreetingId = 0;
            }
            else
            {
                actualGreetingId++;
            }
            //return Content("greeting");
            return Content($"{greetings[actualGreetingId].Content} {name}!");
        }
    }
}