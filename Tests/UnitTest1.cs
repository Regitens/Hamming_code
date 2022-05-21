using System;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            String number = "100";
            int fromBase = 16;
            int toBase = 10;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            Assert.Pass();
        }
    }
}