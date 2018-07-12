using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountAs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a filename as string parameter,
            // counts the occurances of the letter "a", and returns it as a number.
            // If the file does not exist, the function should return 0 and not break.

            // example: on the input "afile.txt" the function should return 28 - print this result
            // example: on the input "not-a-file" the function should return 0 - print this result

            string fileName = "afile.txt";

            Console.WriteLine(FunctCountAs(fileName));
            Console.ReadKey();
        }

        private static int FunctCountAs(string argFileName)
        {
            string contentOfTxt = "";
            int numberOfAsInTxtFile = 0;

            try
            {
                contentOfTxt = File.ReadAllText(argFileName);
            }
            catch (FileNotFoundException)
            {
                return 0;
            }
            catch(Exception)
            {
                return 0;
            }

            foreach (char xChar in contentOfTxt)
            {
                if (Char.ToLower(xChar)=='a')
                {
                    numberOfAsInTxtFile++;
                }   
            }
            return numberOfAsInTxtFile;
        }

    }
}
