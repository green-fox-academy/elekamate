using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies
            // recursively (without loops or multiplication).

            int numberOfBunnies = Int32.Parse(Console.ReadLine());
            Console.WriteLine(RecBunnieCounter(numberOfBunnies));
            Console.ReadKey();
        }

        public static int RecBunnieCounter(int n)
        {
            int bunnieEarNumber;

            if (n%2==0)
            {
                bunnieEarNumber = 3;
            }
            else
            {
                bunnieEarNumber = 2;
            }

            if (n == 0)
            {
                return 0;
            }
            else
            {
                return RecBunnieCounter(n - 1) + bunnieEarNumber;
            }
        }

    }
}
