using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_04_WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            string filePath = @"C:\Users\eleka_000\OneDrive\Documents\Repositories\greenfox\elekamate\week-02\day-03\Practice-02-PrintEachLine\Practice-02-PrintEachLine\my-file.txt";

            try
            {
                StreamWriter sw = File.AppendText(filePath);
                sw.WriteLine("\nMate");
                sw.Dispose();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my - file.txt.");
            }
            Console.ReadKey();
        }
    }
}
