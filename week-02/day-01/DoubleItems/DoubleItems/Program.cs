using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            int[] numList = { 3, 4, 5, 6, 7 };

            for (int i = 0; i < numList.Length; i++)
            {
                numList[i] *= 2;
            }

            foreach (var xElement in numList)
            {
                Console.WriteLine(xElement);
            }

            Console.ReadLine();
        }
    }
}
