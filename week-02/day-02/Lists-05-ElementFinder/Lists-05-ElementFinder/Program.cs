using System;
using System.Collections.Generic;

namespace ElementFinder
{
    public class ElementFinder
    {
        public static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(ContainsSeven(List));
            Console.ReadLine();
            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!

        }
        public static string ContainsSeven (List<int> input_NumberList)
        {
            bool foundSeven = false;
            foreach (var xItem in input_NumberList)
            {
                if (xItem==7)
                {
                    foundSeven = true;
                    break;
                }
            }
            if (foundSeven==true)
            {
                return "Hoorray";
            }
            else
            {
                return "Noooooo";
            }
        }
    }
}