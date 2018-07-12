using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a list as a parameter,
            // and returns a new list with every second element from the orignal list
            // example: [1, 2, 3, 4, 5] should produce [2, 4] - print this result
            List<int> inputList = new List<int>();
            List<int> outputList = new List<int>();
            inputList.Add(1);
            inputList.Add(2);
            inputList.Add(3);
            inputList.Add(4);
            inputList.Add(5);

            outputList = GetEverySecondElementOfAList(inputList);

            Console.ReadKey();
        }

        private static List<int> GetEverySecondElementOfAList(List<int> argInputList)
        {
            bool elementGoesToOutput = false;
            List<int> outputList = new List<int>();

            foreach (var xElement in argInputList)
            {
                if (elementGoesToOutput==true)
                {
                    outputList.Add(xElement);
                }
                elementGoesToOutput = ChangeBoolElementGoesToOutput(elementGoesToOutput);
            }
            return outputList;
        }

        private static bool ChangeBoolElementGoesToOutput(bool argElementGoesToOutput)
        {
            return (argElementGoesToOutput == true) ? false : true;
        }

    }
}
