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
        private static int actualGreetingId = 0;
        private static int counterGreeting = 0;

        private static int actualHelloId = 0;
        private static int counterHello = 0;

        public static List<Greeting> greetings = new List<Greeting>()
        {
            new Greeting {Id=0, Content="Hello"},
            new Greeting {Id=1, Content="Szia"}
        };

        string[] hellos = {"Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
                "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
                "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
                "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};

        public IActionResult Index()
        {
            return Content("testapi");
        }

        [Route("api/greeting")]
        public IActionResult Greeting(string name)
        {
            counterGreeting++;
            string actulaGreeting = greetings[actualGreetingId].Content;

            if (actualGreetingId + 1 == greetings.Count)
            {
                actualGreetingId = 0;
            }
            else
            {
                actualGreetingId++;
            }
            //return Content("greeting");
            return Content($"{actulaGreeting} {name}! {Environment.NewLine}This site was loaded {counterGreeting} times since last server start.");
        }

        [Route("api/greetingmulti")]
        public IActionResult Hello(string name)
        {
            counterHello++;
            string actualHello = hellos[actualHelloId];

            if (actualHelloId + 1 == hellos.Length)
            {
                actualHelloId = 0;
            }
            else
            {
                actualHelloId++;
            }
            //return Content("Hello");
            return Content($"{actualHello} {name}! {Environment.NewLine}This site was loaded {counterHello} times since last server start.");
        }
    }
}