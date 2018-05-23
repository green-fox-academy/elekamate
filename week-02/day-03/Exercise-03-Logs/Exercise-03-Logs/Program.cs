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
        public string[] LogArray { get; private set; }

        static void Main(string[] args)
        {
            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.
            string pathLogsTxt = @"C:\Users\eleka_000\OneDrive\Documents\Repositories\greenfox\elekamate\week-02\day-03\Exercise-03-Logs\Exercise-03-Logs\logs.txt";
            string[] actualLineArray;
            Dictionary<string,string> dictLogIPs = new Dictionary<string,string>();
            string[] logArray=null;
            string[] arrayLogIPs;
            int arrayLogIPIndexCounter = -1;
            int logID = 0;
            string actualGetOrPost = "";
            int GETCounter = 0;
            int POSTCounter = 0;
            double getPostRatio = 0;
            string actualIP = "";

            ImportLogData(pathLogsTxt);
            

            try
            {
                for (int iCreatingDictFromTxt = 0; iCreatingDictFromTxt < logArray.Length; iCreatingDictFromTxt++)
                {
                    logID += 1;
                    actualLineArray = logArray[iCreatingDictFromTxt].Split();
                    actualGetOrPost = actualLineArray[11];
                    actualIP = actualLineArray[8];

                    if (dictLogIPs.ContainsKey(actualIP) == false)
                    {
                        dictLogIPs.Add(actualIP, "");
                    }

                    if (actualGetOrPost == "GET")
                    {
                        GETCounter += 1;
                    }
                    if (actualGetOrPost == "POST")
                    {
                        POSTCounter += 1;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("There is problem with the data, wrong data type in wrong field.");
            }

            getPostRatio = (double) GETCounter / (double)POSTCounter;
            arrayLogIPs = new string[dictLogIPs.Count];

            foreach (var xKey in dictLogIPs.Keys)
            {
                arrayLogIPIndexCounter += 1;
                arrayLogIPs[arrayLogIPIndexCounter] = xKey;
            }
            Console.WriteLine("GET/POST ratio: " + getPostRatio);
            Console.ReadKey();
        }

        private void ImportLogData(string argPathLogsTxt)
        {
            try
            {
                logArray = File.ReadAllLines(argPathLogsTxt);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot open file.");
            }
        }
    }
}
