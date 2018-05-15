using System;
using System.Collections.Generic;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 15 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(list));
            Console.ReadLine();
        }
        public static bool CheckNums(List<int> input_NumberList)
        {
            bool found4 = false;
            bool found8 = false;
            bool found12 = false;
            bool found16 = false;
            foreach (var xItem in input_NumberList)
            {
                if (xItem == 4)
                {
                    found4 = true;
                }
                if (xItem == 8)
                {
                    found8 = true;
                }
                if (xItem == 12)
                {
                    found12 = true;
                }
                if (xItem == 16)
                {
                    found16 = true;
                }
            }

            if (found4==true && found8==true && found12==true && found16==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}