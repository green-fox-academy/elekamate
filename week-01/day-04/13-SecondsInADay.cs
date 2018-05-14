using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            // Day in seconds
            double dayInSeconds = 24 * 60 * 60;
            double pastSeconds;
            double remainingSeconds;

            pastSeconds = currentHours * 60 * 60 + currentMinutes * 60 + currentSeconds;
            remainingSeconds = dayInSeconds - pastSeconds;

            Console.WriteLine("Remaining seconds: " + remainingSeconds);
        }
    }
}
