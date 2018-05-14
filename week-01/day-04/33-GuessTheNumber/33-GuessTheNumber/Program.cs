using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int numberSecret = 8;
            int numberGuess = 0;

            while (numberGuess != numberSecret)
            {
                Console.Write("Guess a number: ");
                numberGuess = Convert.ToInt32(Console.ReadLine());
                if (numberGuess > numberSecret)
                {
                    Console.WriteLine("The number is lower.");
                }
                else if (numberGuess < numberSecret)
                {
                    Console.WriteLine("The number is higher.");
                }
            };

            Console.WriteLine("You found the number: " + numberSecret + ".");
            Console.ReadLine(); 
        }
    }
}
