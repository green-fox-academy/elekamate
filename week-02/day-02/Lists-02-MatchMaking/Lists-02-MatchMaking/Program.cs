using System;
using System.Collections.Generic;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.WriteLine(MakingMatches(girls, boys));
            Console.ReadLine();
        }

        public static string MakingMatches(List<string> girls, List<string> bois)
        {
            int numberOfPairs = 0;
            string outputString = "";

            if (girls.Count < bois.Count)
            {
                numberOfPairs = girls.Count;
            }
            else
            {
                numberOfPairs = bois.Count;
            }

            for (int i = 0; i < numberOfPairs; i++)
            {
                outputString += girls[i] + ", " + bois[i] + ", ";
            }

            outputString=outputString.Substring(0, outputString.Length - 2);
            return outputString;
        }
    }
}