using System;
using System.Collections.Generic;

namespace StudentCounter
{
    public class StudentCounter
    {
        public static void Main(string[] args)
        {
            var map = new List<Dictionary<string, object>>();
            List<string> pplWith5OrMoreCandies = new List<string>();
            decimal sumOfAge_pplWhoHas4OrLessCandies = 0;
            var tempDictionary =new Dictionary<string, object>();
            int actualPerson_NumberOfCandyez = 0;
            decimal actualPerson_Age = 0;
            string atctualPerson_Name = "";

            // Given this list of hashmaps...

            var row0 = new Dictionary<string, object>();
            row0.Add("name", "Rezso");
            row0.Add("age", 9.5);
            row0.Add("candies", 2);
            map.Add(row0);

            var row1 = new Dictionary<string, object>();
            row1.Add("name", "Gerzson");
            row1.Add("age", 10);
            row1.Add("candies", 1);
            map.Add(row1);

            var row2 = new Dictionary<string, object>();
            row2.Add("name", "Aurel");
            row2.Add("age", 7);
            row2.Add("candies", 3);
            map.Add(row2);

            var row3 = new Dictionary<string, object>();
            row3.Add("name", "Zsombor");
            row3.Add("age", 12);
            row3.Add("candies", 5);
            map.Add(row3);

            var row4 = new Dictionary<string, object>();
            row4.Add("name", "Olaf");
            row4.Add("age", 12);
            row4.Add("candies", 7);
            map.Add(row4);

            var row5 = new Dictionary<string, object>();
            row5.Add("name", "Teodor");
            row5.Add("age", 3);
            row5.Add("candies", 2);
            map.Add(row5);

            // Display the following things:
            //  - Who has got more candies than 4 candies
            //  - Sum the age of people who have lass than 5 candies

            // Filling result data structures
            foreach (var xItem in map)
            {
                tempDictionary = xItem;
                actualPerson_NumberOfCandyez=Convert.ToInt32(tempDictionary["candies"]);
                actualPerson_Age =Convert.ToDecimal(tempDictionary["age"]);
                atctualPerson_Name = Convert.ToString(tempDictionary["name"]);

                if (actualPerson_NumberOfCandyez <= 4)
                {
                    sumOfAge_pplWhoHas4OrLessCandies += actualPerson_Age;
                }
                else
                {
                    pplWith5OrMoreCandies.Add(atctualPerson_Name);
                }
            }


            // Printing results
            Console.WriteLine("People who have more than 4 candies:");
            foreach (var xItem in pplWith5OrMoreCandies)
            {
                Console.WriteLine(xItem);
            }
            Console.WriteLine();
            Console.Write("Sum the age of people who have lass than 5 candies:");
            Console.WriteLine(String.Format("{0:N}", sumOfAge_pplWhoHas4OrLessCandies));
            Console.ReadLine();
        }
    }
}