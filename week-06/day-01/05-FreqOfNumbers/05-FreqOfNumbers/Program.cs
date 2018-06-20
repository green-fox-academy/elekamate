using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FreqOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var freqOfNumbers = from number in n
                                            orderby number
                                             group number by number into numberFreq
                                             select numberFreq;

            var freqOfNumbersLINQ = n
                .OrderBy(x => x)
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());

            foreach (var number in freqOfNumbers)
            {
                Console.WriteLine($"{number.Key}: {number.Count()}");
            }

            foreach (var number in freqOfNumbersLINQ)
            {
                Console.WriteLine($"{number.Key}: {number.Count()}");
            }
            Console.ReadLine();
        }
    }
}
