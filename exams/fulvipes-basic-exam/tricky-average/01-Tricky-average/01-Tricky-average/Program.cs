using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Tricky_average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = new int[] { 1, 2, 3 };
            Console.WriteLine(TrickyAverage.TrickyAverage.GetTrickyAvg(inputNumbers));
            Console.ReadLine();
        }
    }
}
