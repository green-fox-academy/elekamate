using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            Console.Write("Number of lines of the pyramid: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string outputString = "";

            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                outputString = "";
                for (int j = 0; j < number-i; j++)
                {
                    outputString += " ";
                }
                for (int j = 0; j < i*2 + 1; j++)
                {
                    outputString += "*";
                }
                Console.WriteLine(outputString);
            }

            Console.ReadLine();
        }
    }
}
