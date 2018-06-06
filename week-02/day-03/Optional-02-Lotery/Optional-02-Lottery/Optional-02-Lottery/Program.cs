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
            Dictionary<int, int> lotteryNumberFreq = CreateNumberFreqDict(lotteryNumbers);
            List<int> top5LotteryNumbers = Findtop5LotteryNumbers(lotteryNumberFreq);

            Console.ReadLine();
        }

        private static List<int> ImportLotteryNumbersToList(string argLotteryDatafilePath)
        {
            string[] lotteryDataRaw = File.ReadAllLines(argLotteryDatafilePath);
            List<int> lotteryNumbers = new List<int>();
            lotteryNumbers = LoadLotteryNumbersToList(lotteryDataRaw);
            return lotteryNumbers;
        }

        private static List<int> LoadLotteryNumbersToList(string[] lotteryDataRaw)
        {
            List<int> lotteryNumbers = new List<int>();
            string[] tempLineContent;
            foreach (string xLine in lotteryDataRaw)
            {
                tempLineContent = xLine.Split(';');
                for (int i = tempLineContent.Length - 1; i > tempLineContent.Length - 6; i--)
                {
                    lotteryNumbers.Add(Convert.ToInt32(tempLineContent[i]));
                }
            }
            return lotteryNumbers;
        }

        private static Dictionary<int, int> CreateNumberFreqDict(List<int> argLotteryNumbers)
        {
            Dictionary<int, int> lotteryNumberFreq = new Dictionary<int, int>();
            foreach (int xNumber in argLotteryNumbers)
            {
                if (lotteryNumberFreq.ContainsKey(xNumber))
                {
                    lotteryNumberFreq[xNumber]++;
                }
                else
                {
                    lotteryNumberFreq.Add(xNumber, 1);
                }
            }
            return lotteryNumberFreq;
        }

        private static List<int> Findtop5LotteryNumbers(Dictionary<int, int> arglotteryNumberFreq)
        {
            List<int> top5LotteryNumbers = new List<int>();
            int prevFreq=0;
            int givenFreq = 0;
            int givenKey = 0;

            while (true)
            {
                foreach (var xKey in arglotteryNumberFreq.Keys)
                {
                    if (arglotteryNumberFreq.Values.Max() == arglotteryNumberFreq[xKey])
                    {
                        top5LotteryNumbers.Add(xKey);
                        givenKey = xKey;
                        prevFreq = givenFreq;
                        givenFreq = arglotteryNumberFreq[xKey];
                        arglotteryNumberFreq.Remove(xKey);
                        break;
                    }
                }
                if (top5LotteryNumbers.Count > 4 && prevFreq != givenFreq)
                {
                    if (top5LotteryNumbers.Count > 5)
                    {
                        top5LotteryNumbers.Remove(givenKey);
                    }
                    break;
                }
            }
            return top5LotteryNumbers;
        }
    }
}
