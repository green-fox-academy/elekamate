using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };

            // Saturn is missing from the planetList
            // Insert it into the correct position
            planetList.Insert(6, "Saturn");
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.
            Console.WriteLine(PutSaturn(planetList));
            Console.ReadLine();
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"
        }

        public static string PutSaturn (List<string> inputList)
        {
            return "\"" + String.Join("\", \" ", inputList) + "\"";
        }
    }
}