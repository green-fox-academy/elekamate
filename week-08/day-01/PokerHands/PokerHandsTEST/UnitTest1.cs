using NUnit.Framework;
using System;
using PokerHands;

namespace PokerHandsTEST
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(5, Poker.ProgiTest());
        }
    }
}
