using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_FindTheSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes two strings as a parameter
            //  Returns the starting index where the second one is starting in the first one
            //  Returns `-1` if the second string is not in the first one

            //  Example:
            //Console.WriteLine(Substr("this is what I'm searching in", "searching"));
            //  should print: `17`
            //Console.WriteLine(Substr("this is what I'm searching in", "not"));
            //  should print: `-1`

            Console.Write("Gimme string 1:");
            //string str1 = Console.ReadLine();
            Console.Write("Gimme string 2:");
            //string str2 = Console.ReadLine();

            Console.WriteLine("");
            //Console.WriteLine(Substr(str1, str2));

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(Substr("this is what I'm fsearching in", "searching"));
            Console.WriteLine(Substr("this is what I'm searching in", "not"));
            Console.ReadLine();
        }

        static int Substr(string str1, string str2)
        {
            int str1_len = str1.Length;
            int str2_len = str2.Length;

            for (int i = 0; i < str1_len - str2_len +1; i++)
            {
                if (str2 == str1.Substring(i, str2_len))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
