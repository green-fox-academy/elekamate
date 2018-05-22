using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01_CopyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            string filePath_Copy = @"C:\Users\eleka_000\OneDrive\Documents\Repositories\greenfox\elekamate\week-02\day-03\Practice-02-PrintEachLine\Practice-02-PrintEachLine\my-file.txt";
            string filePath_Paste = @"C:\Users\eleka_000\OneDrive\Documents\Repositories\greenfox\elekamate\week-02\day-03\Practice-02-PrintEachLine\Practice-02-PrintEachLine\copyTo.txt";

            if (CopyTextFile(filePath_Copy, filePath_Paste)==true)
            {
                Console.WriteLine("Successful run.");
            }
            else
            {
                Console.WriteLine("Unsuccessful run.");
            }
            Console.ReadKey();
        }

        static bool CopyTextFile(string filePath_Copy,string filePath_Paste)
        {
            try
            {
                string data = "";
                StreamReader sr = new StreamReader(filePath_Copy);
                data = sr.ReadToEnd();
                sr.Dispose();

                StreamWriter sw = File.AppendText(filePath_Paste);
                sw.WriteLine(data);
                sw.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
