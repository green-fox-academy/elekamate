
using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            Console.WriteLine(QuoteSwapMeth(list));
            Console.ReadLine();
            // Expected output: "What I cannot create I do not understand." 
        }
        public static string QuoteSwapMeth(List<string> inputList)
        {
            string outputString = "";

            for (int i = 0; i < inputList.Count; i++)
            {
                if (i==2)
                {
                    outputString += inputList[5] + " ";
                }
                else if (i==5)
                {
                    outputString += inputList[2] + " ";
                }
                else
                {
                    outputString += inputList[i] + " ";
                }
            }

            outputString = outputString.Substring(0, outputString.Length - 1);
            return outputString;
        }
    }
}