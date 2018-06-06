using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_sum
{
    public class Calc
    {
        public static int SumNumbers (List<int> numbersToSum)
        {
            int sum = 0;
            foreach (int xNumber in numbersToSum)
            {
                sum += xNumber;
            }
            return sum;
        }
    }
}
