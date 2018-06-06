using _01_Apples_Final;
using NUnit.Framework;
using System;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            string expected = "apple";
            Calc calc = new Calc();
            string actual = calc.GetApple();
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
