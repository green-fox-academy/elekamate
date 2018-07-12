using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Test
    {
        /**
        * Write your test cases here. You should be able to invoke the method like this:
        * double result = TrickyAverage.GetTrickyAvg(input);
        */
        //     * Example cases:
        //* [1, 2, 3] -> should return 1.5
        //* [3, 4, 5, 6] -> should return 4.5
        //* [5, 2, 8, -1] -> should return 3.5
        [Test]
        public void GetTrickyAvg_testCase1()
        { 
            int[] inputNumbers = new int[] { 1, 2, 3 };
            double actualOutput = TrickyAverage.TrickyAverage.GetTrickyAvg(inputNumbers);
            Assert.AreEqual(1.5, actualOutput);
        }

        [Test]
        public void GetTrickyAvg_testCase2()
        {
            int[] inputNumbers = new int[] { 3, 4, 5, 6 };
            double actualOutput = TrickyAverage.TrickyAverage.GetTrickyAvg(inputNumbers);
            Assert.AreEqual(4.5, actualOutput);
        }
    }
}
