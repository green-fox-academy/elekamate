using _02_sum;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public static void TestMethod1()
        {
            List<int> inputNumbers = new List<int> { 1, 2, 3, 4 };
            int expectedOutput = 10;
            int calcOutput = Calc.SumNumbers(inputNumbers);
            Assert.AreEqual(expectedOutput, calcOutput);
        }
    }
}
