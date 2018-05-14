using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `am` and assign the value `kuty` to it
            // - Write a function called `appendA` that gets a string as an input,
            //   appends an 'a' character to its end and returns with a string
            // - Print the result of `appendAFunc(am)`

            string am = "kuty";

            Console.WriteLine(AppendAFunc(am));
            Console.ReadLine();
        }
        static string AppendAFunc(string am)
        {
            return am + "a";
        }
    }
}
