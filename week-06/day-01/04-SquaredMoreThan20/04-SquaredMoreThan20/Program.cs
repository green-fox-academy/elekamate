using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SquaredMoreThan20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            IEnumerable<int> squaredMoreThan20 = from number in n
                                                 where number * number > 20
                                                 select number;

            IEnumerable<int> squaredMoreThan20LINQ = n.Where(number => number * number > 20);

            Console.WriteLine(string.Join(", ", squaredMoreThan20));
            Console.WriteLine(string.Join(", ", squaredMoreThan20LINQ));
            Console.ReadLine();
        }
    }
}
