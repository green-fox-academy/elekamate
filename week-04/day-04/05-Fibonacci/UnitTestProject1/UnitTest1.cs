using _05_Fibonacci;
using NUnit.Framework;
using System;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(0)]
        public static void TestMethod1(int inputNumbers)
        {
            Assert.AreEqual(inputNumbers, Calc.CalcFibonacci(0));
        }

        [TestCase(6)]
        public static void TestMethod3(int inputNumbers)
        {
            Assert.AreEqual(inputNumbers, Calc.CalcFibonacci(3));
        }
    }
}
