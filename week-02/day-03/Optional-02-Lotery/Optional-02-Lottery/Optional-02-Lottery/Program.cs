using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_02_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that find the 5 most common lottery numbers in lottery.csv
            string lotteryDatafilePath = "lottery.csv";
            List<int> lotteryNumbers = ImportLotteryNumbersToList(lotteryDatafilePath);
            Console.ReadLine();
        }

        private static List<int> ImportLotteryNumbersToList(string argLotteryDatafilePath)
        {
            string[] lotteryDataRaw = File.ReadAllLines(argLotteryDatafilePath);
            List<int> lotteryNumbers = new List<int>();
            string[] tempLineContent;
            foreach (string xLine in lotteryDataRaw)
            {
                tempLineContent = xLine.Split(';');
                for (int i = tempLineContent.Length-1; i > tempLineContent.Length - 6; i--)
                {
                    lotteryNumbers.Add(Convert.ToInt32(tempLineContent[i]));
                }
            }
            return lotteryNumbers;
        }
    }
}
