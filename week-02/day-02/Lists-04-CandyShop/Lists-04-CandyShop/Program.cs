using System;
using System.Collections.Generic;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Console.WriteLine(Sweets(list));
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
            Console.ReadLine();
        }
        public static string Sweets(List<object> candyList)
        {
            string outputString = "\"";
            string actualValue = "";
            for (int i = 0; i < candyList.Count; i++)
            {
                actualValue = candyList[i].ToString();
                if (actualValue.Equals("2"))
                {
                    candyList[i] = "Croissant";
                }
                else if (actualValue=="False")
                {
                    candyList[i] = "Ice cream";
                }
                outputString += candyList[i] + "\", \"";
            }
            outputString = outputString.Substring(0, outputString.Length - 3);
            return outputString;
        }
    }
}