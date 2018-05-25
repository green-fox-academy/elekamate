using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            Console.WriteLine(RecursiveCountback(4)); 
            Console.ReadKey();
        }
        static int RecursiveCountback(int n)
        {
            if (n==0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(n);
                return RecursiveCountback(n - 1);
            }
        }
    }
}
