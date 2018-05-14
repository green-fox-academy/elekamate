using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
            int[] aj_Orig = { 3, 4, 5, 6, 7 };
            int[] aj_Reversed = new int[aj_Orig.Length];

            for (int i = 0; i < aj_Orig.Length; i++)
            {
                aj_Reversed[aj_Orig.Length-1 - i] = aj_Orig[i];
            }

            Console.ReadLine();
        }
    }
}
