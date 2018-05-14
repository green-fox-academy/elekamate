using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer

            int numberOfNumbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Sum(numberOfNumbers));

            Console.ReadLine();
        }

        static int Sum(int numberOfNumbers)
        {
            int actual_NumberToAdd=0;
            int sumOfNumbers = 0;
            for (int i = 1; i < numberOfNumbers+1; i++)
            {
                actual_NumberToAdd = Convert.ToInt32(Console.ReadLine());
                sumOfNumbers += actual_NumberToAdd;
            }
            return sumOfNumbers;
        }
    }
}
