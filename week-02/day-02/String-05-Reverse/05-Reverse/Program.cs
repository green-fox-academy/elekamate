using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(ReversedString(reversed));

            Console.ReadLine();
        }
        public static string ReversedString(string inputString)
        {
            int inputString_n = inputString.Length;
            string outputString = "";

            for (int i = inputString_n-1; i > -1; i--)
            {
                outputString += inputString[i];
            }
            return outputString;
        }
    }
}