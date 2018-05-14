using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`

            string a1 = "Greenfox";

            Console.WriteLine(Greet(a1));
            Console.ReadLine();
        }
        static string Greet (string a1)
        {
            return "Greetings dear, " + a1;
        }
    }
}
