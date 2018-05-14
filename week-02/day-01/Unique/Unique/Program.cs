using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            Console.WriteLine(Unique(new int[] { 1, 11, 34, 11, 52, 61, 1, 34}));
            //  should print: `[1, 11, 34, 52, 61]`
        }
        static int[] Unique(int[] uniq_InputList)     
        {
            int uniqueCounter = uniq_InputList.Length;
            int[] uniq_OutputList = new int[uniqueCounter];
            int[] uniq_InputList_Neglect = new int[uniq_InputList.Length];
            bool number_Unique = false;
            int uniq_OutputList_actualIndex = -1;

            for (int i = 0; i < uniq_InputList.Length; i++)
            {
                for (int j = 0; j < uniq_InputList_Neglect.Length; j++)
                {
                    if (uniq_InputList_Neglect[j]==1)
                    {
                        goto endOfUniqueCounterLoop;
                    }
                }

                for (int j = 0; j < uniq_InputList.Length; j++)
                {
                    if (uniq_InputList[i]==uniq_InputList[j])
                    {
                        
                        uniqueCounter -= 2;
                        uniq_InputList_Neglect[i] = 1;
                        uniq_InputList_Neglect[j] = 1;
                    }
                }
                endOfUniqueCounterLoop:;
            }

            for (int i = 0; i < uniq_InputList.Length; i++)
            {
                number_Unique = false;

                for (int j = 0; j < uniq_InputList.Length; j++)
                {
                    if (uniq_InputList[i] == uniq_InputList[j])
                    {
                        uniqueCounter -= 1;
                        uniq_OutputList_actualIndex += 1;
                        number_Unique = true;

                        uniq_OutputList[uniq_OutputList_actualIndex] = uniq_InputList[i];
                    }
                }

                if (number_Unique == false)
                {
                    uniq_OutputList_actualIndex += 1;

                    uniq_OutputList[uniq_OutputList_actualIndex] = uniq_InputList[i];
                }
            }
            return uniq_OutputList;
        }
    }
}
