using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user

            Console.WriteLine("Gimme ur name.");
            string userName = Console.ReadLine();
            
            Console.WriteLine("Hello, {0}!", userName);
            Console.ReadLine();
        }
    }
}
