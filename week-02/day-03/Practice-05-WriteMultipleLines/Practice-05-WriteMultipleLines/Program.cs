using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_05_WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.

            string filePath = @"C:\Users\eleka_000\OneDrive\Documents\Repositories\greenfox\elekamate\week-02\day-03\Practice-02-PrintEachLine\Practice-02-PrintEachLine\my-file.txt";

            WriteMultipleLines(filePath, "cica", 4);
            Console.ReadKey();
        }

        static void WriteMultipleLines(string filePath, string word, int numberOfTimes)
        {
            try
            {
                Console.WriteLine(File.Exists(filePath));
                if (File.Exists(filePath) == false)
                {
                    throw new FileNotFoundException();
                }

                StreamWriter sw = File.AppendText(filePath);
                for (int i = 0; i < numberOfTimes; i++)
                {
                    sw.WriteLine();
                    sw.Write(word);
                }
                sw.Dispose();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot write file.");
            }
        }
    }
}
