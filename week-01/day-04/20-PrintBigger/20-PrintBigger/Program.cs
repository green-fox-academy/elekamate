using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.Write("Number 1: ");
            int actNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int actNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (actNumber1 > actNumber2)
            {
                Console.WriteLine("Number 1 is bigger.");
            }
            else if (actNumber2 > actNumber1)
            {
                Console.WriteLine("Number 2 is bigger.");
            }
            else
            {
                Console.WriteLine("Equal.");
            }

            Console.ReadLine();
        }
    }
}
