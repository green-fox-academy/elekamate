using System;
using System.Collections.Generic;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            Console.ReadLine();
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
        }
        public static string AppendA(List<string> far)
        {
            string outputString="\"";
            for (int i = 0; i < far.Count; i++)
            {
                far[i] = far[i] + "a";
                outputString += far[i] + "\", ";
            }
            outputString=outputString.Substring(0, outputString.Length - 2);
            return outputString;
        }
    }
}