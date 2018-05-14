using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_ParametricAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            string actualNumber = "0";
            int actualNumberInt = 0;
            decimal sum = 0;
            int count = 0;
            decimal avg = 0;

            do
            {
                actualNumber = Console.ReadLine();

                if (int.TryParse(actualNumber, out actualNumberInt) == true)
                {
                    sum += actualNumberInt;
                    count += 1;
                }
            } while (int.TryParse(actualNumber, out actualNumberInt) == true);

            avg = sum / count;

            Console.WriteLine("Sum: " + sum + ", Average: " + avg);
            Console.ReadLine();
        }
    }
}
