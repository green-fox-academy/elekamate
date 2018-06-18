using _05_Fibonacci;
using NUnit.Framework;
using System;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        Calc calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calc();
        }

        [TearDown]
        public void TearDown()
        {
            calc = null;
        }

        [TestCase(0)]
        public void TestMethod1(int inputNumbers)
        {
            Assert.AreEqual(inputNumbers, calc.CalcFibonacci(0));
        }

        [TestCase(6)]
        public void TestMethod3(int inputNumbers)
        {
            Assert.AreEqual(inputNumbers, calc.CalcFibonacci(3));
        }
    }
}
