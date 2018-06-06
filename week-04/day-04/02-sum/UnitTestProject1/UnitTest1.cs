using _02_sum;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        Calc calc;

        //[SetUp]
        //public void SetUp()
        //{
        //    calc = new Calc();
        //}

        [TestCase(10)]
        public static void TestForMultiElement(int inputNumbers)
        {
            Assert.AreEqual(inputNumbers, Calc.SumNumbers(new List<int> { 1, 2, 3, 4 }));
        }

        [TestCase(0)]
        public static void TestForEmpty(int inputNumbers)
        {
            Assert.AreEqual(inputNumbers, Calc.SumNumbers(new List<int> {  }));
        }

        [TestCase(15)]
        public static void TestForOneElement(int inputNumbers)
        {
            Assert.AreEqual(inputNumbers, Calc.SumNumbers(new List<int> { 15 }));
        }

        [TestCase(15)]
        public static void TestForNull(int inputNumbers)
        {
            Assert.AreEqual(inputNumbers, Calc.SumNumbers(new List<int> { null }));
        }
    }
}
