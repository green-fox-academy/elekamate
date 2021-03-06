using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was
            Console.Write("Number of lines of the square: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string outputString = "";

            Console.WriteLine();

            for (int i = 1; i < number+1; i++)
            {
                outputString = "%";
                if (i == 1 || i == number)
                {
                    for (int j = 2; j < number; j++)
                    {
                        outputString += "%";
                    }
                }
                else
                {
                    for (int j = 2; j < number; j++)
                    {
                        outputString += " ";
                    }
                }
                outputString += "%";
                Console.WriteLine(outputString);
            }
            Console.ReadLine();
        }
    }
}
