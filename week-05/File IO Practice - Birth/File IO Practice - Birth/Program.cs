using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Practice___Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawData = File.ReadAllLines("births.csv");
            List<DateTime> birthDates = new List<DateTime>();
            Dictionary<int, int> birthYearFreq = new Dictionary<int, int>();
            birthDates=GetBirthDatesFromcsv(rawData);
            birthYearFreq=CreateBirthDateFreqDict(birthDates);
            Console.WriteLine(FindMostFrequentBirthYear(birthYearFreq,birthYearFreq.Values.ToList().Max()));
            Console.ReadLine(); 
        }

        private static List<DateTime> GetBirthDatesFromcsv(string[] rawData)
        {
            List<DateTime> birthDates = new List<DateTime>();
            string[] givenRecord;
            foreach (string xLine in rawData)
            {
                givenRecord = xLine.Split(';');
                birthDates.Add(DateTime.Parse(givenRecord[1]));
            }
            return birthDates;
        }

        private static Dictionary<int, int> CreateBirthDateFreqDict(List<DateTime> birthDates)
        {
            Dictionary<int, int> birthYearFreq = new Dictionary<int, int>();
            foreach (var xItem in birthDates)
            {
                if (birthYearFreq.ContainsKey(xItem.Year))
                {
                    birthYearFreq[xItem.Year]++;
                }
                else
                {
                    birthYearFreq.Add(xItem.Year, 1);
                }
            }
            return birthYearFreq;
        }

        private static int FindMostFrequentBirthYear(Dictionary<int, int> birthYearFreq, int maxFreqNumber)
        {
            foreach (var xKey in birthYearFreq.Keys)
            {
                if (birthYearFreq[xKey] == maxFreqNumber)
                {
                    return xKey;
                }
            }
            return 0;
        }
    }
}
