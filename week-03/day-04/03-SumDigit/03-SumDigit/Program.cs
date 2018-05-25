using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

            uint n = UInt32.Parse(Console.ReadLine());
            Console.WriteLine(SumDigitRec(n));
            Console.ReadKey();
        }

        static uint SumDigitRec(uint n)
        {
            string nString = Convert.ToString(n);
            int divider = nString.Length;
            uint actualNumber = UInt32.Parse(nString.Substring(0, 1));

            return divider == 1 
                ? UInt32.Parse(nString.Substring(0, 1)) 
                : SumDigitRec(UInt32.Parse(nString.Substring(1, divider - 1))) + actualNumber;
        }

    }
}
