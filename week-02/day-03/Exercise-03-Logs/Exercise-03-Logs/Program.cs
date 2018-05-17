using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.

            string path_logstxt = @"C:\Users\eleka_000\OneDrive\Documents\Repositories\greenfox\elekamate\week-02\day-03\Exercise-03-Logs\Exercise-03-Logs\logs.txt";


            bool fileExists=File.Exists(path_logstxt);
            Console.ReadKey();
        }
    }
}
