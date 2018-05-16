using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            int divider = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DividingTenWith(divider));
            Console.WriteLine("Testing end of process.");
            Console.ReadKey();
        }

        static int DividingTenWith(int divider)
        {
            try
            {
                return 10 / divider;
            }
            catch (DivideByZeroException exception_ZeroDivider)
            {
                Console.WriteLine(exception_ZeroDivider.Message); 
                return 0;
            }
            
        }
    }
}
