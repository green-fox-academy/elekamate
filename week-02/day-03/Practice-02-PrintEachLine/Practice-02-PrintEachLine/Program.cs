using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_02_PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

            string myFile_Path = @"C:\Users\eleka_000\OneDrive\Documents\Repositories\greenfox\elekamate\week-02\day-03\Practice-02-PrintEachLine\Practice-02-PrintEachLine\my-file2.txt";

            try
            {
                Console.WriteLine(File.ReadAllText(myFile_Path));
            }
            catch (FileNotFoundException exception_FileNotFound)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            
            Console.ReadLine();
        }
    }
}
