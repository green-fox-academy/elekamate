using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_03_CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            string filePath = @"C:\Users\eleka_000\OneDrive\Documents\Repositories\greenfox\elekamate\week-02\day-03\Practice-02-PrintEachLine\Practice-02-PrintEachLine\my-file.txt";

            Console.WriteLine(LineCounterMethod(filePath));
            Console.ReadKey();
        }
        
        static int LineCounterMethod(string filePath)
        {
            string content = "";
            int lineCounter = 0;
            StreamReader sr = new StreamReader(filePath);

            while (content != null)
            {
                content = sr.ReadLine();
                if (content != null)
                {
                    Console.WriteLine(content);
                    lineCounter++;
                }
            }
            return lineCounter;
        }
    }
}
