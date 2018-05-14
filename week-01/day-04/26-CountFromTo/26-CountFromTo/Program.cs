using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            Console.Write("Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number2 <= number1)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Count:");
                for (int i = number1; i < number2+1; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
