using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Apples_2;

namespace ConsoleApp1
{
    [TestFixture]
    public class MathHandler
    {
        [Test]
        public void TestAdd()
        {
            string getAppleOutput = Apple.GetApple();
            Assert.AreEquals(getAppleOutput, "apple");
        }
    }
}
