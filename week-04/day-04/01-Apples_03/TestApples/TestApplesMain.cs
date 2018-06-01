using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace TestApples
{
    [TestFixture]
    class TestApplesMain
    {
        [Test]
        public void TestGetApples()
        {
            string stringToTest = Apples.GetApples();
        }
    }
}
