using System;
using System.Collections.Generic;

namespace TrickyAverage
{
    public class TrickyAverage
    {
        /**
        * Create and test a function called `GetTrickyAvg` that takes a number array (only integers)
        * as parameter
        * and returns the 
        * 
        * average of the 
        * smallest odd and 
        * largest even.
        * 
        *  - use only basic control flow statements, like 'for', 'if', etc.
        *  - do not use built-in methods like `Where`, `Select`, `Average, etc.
        *  - write test for 2 different scenarios (test file is provided: TrickyAverageTest.cs)
        * 
        * Example cases:
        * [1, 2, 3] -> should return 1.5
        * [3, 4, 5, 6] -> should return 4.5
        * [5, 2, 8, -1] -> should return 3.5
        */
        public static double GetTrickyAvg(int[] inputNumbers)
        {
            List<int> inputNumbersList = new List<int>(inputNumbers);
            double smallestOddNumber = 0;
            double largestEvenNumber = 0;
            inputNumbersList.Sort();
            smallestOddNumber = FindSmallestOddNumber(inputNumbersList);
            largestEvenNumber = FindLargestEvenNumber(inputNumbersList);
            return (smallestOddNumber + largestEvenNumber) / 2;
        }

        private static int FindSmallestOddNumber(List<int> inputNumbersList)
        {
            for (int i = 0; i < inputNumbersList.Count; i++)
            {
                if (inputNumbersList[i] % 2 == 1)
                {
                    return inputNumbersList[i];
                }
            }
            return 0;
        }

        private static int FindLargestEvenNumber(List<int> inputNumbersList)
        {
            for (int i = inputNumbersList.Count - 1; i > -1; i--)
            {
                if (inputNumbersList[i] % 2 == 0)
                {
                    return inputNumbersList[i];
                }
            }
            return 1;
        }
    }
}
