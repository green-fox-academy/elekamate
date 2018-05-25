using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciRec(n));
            Console.ReadKey();
        }

        private static int FibonacciRec(int n)
        {
            if (n==1)
            {
                return 1;
            }
            else if (n==0)
            {
                return 0;
            }
            else
            {
                return FibonacciRec(n-1)*n;
            }
        }

    }
}
