using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fibonacci
{
    public class Calc
    {
        public int CalcFibonacci(int n)
        {
            int fibonacciResult = 1;
            if (n==0)
            {
                fibonacciResult = 0;
            }
            else
            {
                
                for (int i = 1; i < n + 1; i++)
                {
                    fibonacciResult *= i;
                }
            }
            
            return fibonacciResult;
        }
    }
}
