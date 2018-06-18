using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            IEnumerable<int> evenNumbersQuery = from number in n
                                                where number % 2 == 0
                                                select number;
            IEnumerable<int> evenNumbersLINQ = n.Where(number => number % 2 == 0);

            foreach (var number in evenNumbersLINQ)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
