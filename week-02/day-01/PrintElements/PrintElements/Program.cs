using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`

            int[] numbers = { 4, 5, 6, 7 };

            foreach (var actualElement in numbers)
            {
                Console.WriteLine(actualElement);
            }       
            Console.ReadLine();
        }
    }
}
