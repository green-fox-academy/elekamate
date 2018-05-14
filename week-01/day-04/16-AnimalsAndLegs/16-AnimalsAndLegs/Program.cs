using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            int numberOfPigs = 0;
            int numberOfChicks = 0;

            int legsOfAPig = 4;
            int legsOfAChick = 2;

            int numberOfAllLegs = 0;

            Console.WriteLine("Pigs:");
            numberOfPigs=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chicks:");
            numberOfChicks= Convert.ToInt32(Console.ReadLine());

            numberOfAllLegs = numberOfPigs * legsOfAPig + numberOfChicks * legsOfAChick;

            cw
        }
    }
}
