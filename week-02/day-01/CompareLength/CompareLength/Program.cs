using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`

            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5, 6, 7 };

            if (p2.Length > p1.Length)
            {
                Console.WriteLine("p2 has more elements.");
            }
            else
            {
                Console.WriteLine("p2 has no more elements.");
            }

            Console.ReadLine();
        }
    }
}
