using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_IWontCheat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
            for (int i = 1; i != 101; i++)
            {
                Console.WriteLine(i + " I won't cheat on the exam!");
            }

            Console.ReadLine();
        }
    }
}
