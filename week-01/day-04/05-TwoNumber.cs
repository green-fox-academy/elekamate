using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints a few operations on two numbers: 22 and 13

            // Print the result of 13 added to 22

            // Print the result of 13 substracted from 22

            // Print the result of 22 multiplied by 13

            // Print the result of 22 divided by 13 (as a decimal fraction)

            // Print the integer part of 22 divided by 13

            // Print the reminder of 22 divided by 13
        	int number1 =13;
		int number2 =22;
		
		int sum = number1 + number2;
		int dif =number2-number1;

		int multi=number1*number2;
		long division= number2/number1;
		
		int divident=Convert.ToInt32(Math.Floor(division));
		int reminder=number2%number1;
		
		Console.WriteLine("Sum: {0}", sum);
		Console.WriteLine("diff: {0}", dif);
		Console.WriteLine("multip: {0}", multi);
		Console.WriteLine("division: {0}", division);
		Console.WriteLine("divide: {0}", divident);
		Console.WriteLine("mod: {0}", reminder);	
	}
    }
}
