using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”.
            // For numbers which are multiples of both three and five print “FizzBuzz”.

            bool dividableBy_3 = false;
            bool dividableBy_5 = false;

            for (int i = 1; i < 101; i++)
            {
                dividableBy_3 = false;
                dividableBy_5 = false;

                Console.Write(i + " ");

                if (i % 3 == 0)
                {
                    dividableBy_3 = true;  
                }

                if (i % 5 == 0)
                {
                    dividableBy_5 = true;
                }

                if (dividableBy_3 == true && dividableBy_5 == true)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (dividableBy_3 == true)
                {
                    Console.WriteLine("Fizz");
                }
                else if (dividableBy_5 == true)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
