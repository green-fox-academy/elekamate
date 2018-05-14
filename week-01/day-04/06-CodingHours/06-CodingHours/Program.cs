using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            double codingHoursDaily_Avg = 6;
            int semesterTimeWeeks = 17;
            int codingDaysWeekly = 5;
            double workingHoursWeekly = 52;

            double semesterCodingHours =  semesterTimeWeeks * codingDaysWeekly * codingHoursDaily_Avg;
            double codingHoursRatePerDay = codingHoursDaily_Avg * codingDaysWeekly / workingHoursWeekly;

            Console.WriteLine("Coding hours during one semester: {0:0.00}", semesterCodingHours);
            Console.WriteLine("Percentage of coding hours: {0:0.00}", codingHoursRatePerDay);
            Console.ReadLine();
        }
    }
}
