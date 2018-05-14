using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            Console.WriteLine("Gimme a number! I will tell ya if the number is odd or not.");
            decimal actualNumber = Convert.ToDecimal( Console.ReadLine());

            if (actualNumber % 2 ==0)
            {
                Console.WriteLine("Odd.");
            }
            else
            {
                Console.WriteLine("Even.");
            }
            Console.ReadLine();
        }
    }
}
