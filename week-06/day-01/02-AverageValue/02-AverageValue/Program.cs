using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AverageValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            double averageOfNumbers = (from number in numbers
                                    where number % 2 == 1
                                    select number).ToList().Average();
            double averageOfNumbersLINQ = numbers.Where(number => number % 2 == 1).ToList().Average();
            Console.WriteLine(averageOfNumbers);
            Console.WriteLine(averageOfNumbersLINQ);
            Console.ReadLine();
        }
    }
}
