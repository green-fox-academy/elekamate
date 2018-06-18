using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SquaredPositiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            IEnumerable<int> sqPositiveNumbers = from number in numbers
                                                 where number >= 0
                                                 select number * number;
            IEnumerable<int> sqPositiveNumbersLINQ = numbers
                .Where(number => number >= 0)
                .Select(number => number * number);
            Console.WriteLine(string.Join(", ", sqPositiveNumbers));
            Console.WriteLine(string.Join(", ", sqPositiveNumbersLINQ));
            Console.ReadLine();
        }
    }
}
