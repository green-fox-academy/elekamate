using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            double kmToMile = 1.60934;

            Console.WriteLine("Gimme the km in integer.");
            int input_Km = Convert.ToInt32(Console.ReadLine());

            double output_Mile = input_Km * kmToMile;

            Console.WriteLine("Converted to mile: " + output_Mile);
            Console.ReadLine();
        }
    }
}
