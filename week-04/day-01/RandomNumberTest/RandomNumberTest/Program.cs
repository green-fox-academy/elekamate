using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            Console.WriteLine(randomGenerator.Next(51));

            Console.ReadKey();
        }
    }
}
