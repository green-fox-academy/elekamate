using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            int tempA = a;
            a=b;
            b = tempA;
            Console.WriteLine("a: {0}, b: {1}.", a, b);
            Console.ReadLine();
        }
    }
}
