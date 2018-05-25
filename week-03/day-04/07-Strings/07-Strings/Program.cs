using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

            string inputString = Console.ReadLine();
            Console.WriteLine(ConvertString(inputString)); 

            Console.ReadKey();
        }

        private static string ConvertString(string argInputString)
        {
            int inputStringLength = argInputString.Length;
            char actualString = argInputString[inputStringLength - 1];
            string newInputString = "";

            if (actualString=='x')
            {
                actualString = 'y';
            }

            if (inputStringLength==1)
            {
                newInputString = Convert.ToString(actualString);
                return newInputString;
            }
            else
            {
                newInputString = argInputString.Substring(0, inputStringLength - 1);
                return ConvertString(newInputString) + actualString;
            }
            
        }
    }
}
