using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations,
            // reate a method named "Calculate()":
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            List<string> calculationInputList = new List<string>();
            string calculationInputString="";

            Console.Write("Please type in the expression:");
            calculationInputString = Console.ReadLine();
            calculationInputList=calculationInputString.Split(' ').ToList();

            CalculatorCalculation(calculationInputList);

            Console.WriteLine(String.Format("{0:N}", CalculatorCalculation(calculationInputList)));


            Console.ReadLine();
        }
        public static decimal CalculatorCalculation(List<string> calculationInput)
        {
            string mathAction = calculationInput[0];
            int number1 =Convert.ToInt32(calculationInput[1]);
            int number2 = Convert.ToInt32(calculationInput[2]);

            if (mathAction == "+")
            {
                return number1 + number2;
            }
            else if (mathAction == "-")
            {
                return number1 - number2;
            }
            else if (mathAction == "*")
            {
                return number1 * number2;
            }
            else if (mathAction == "/")
            {
                return number1 / number2;
            }
            else if (mathAction == "%")
            {
                return number1 % number2;
            }
            else
            {
                return 0;
            }
        }
    }
}