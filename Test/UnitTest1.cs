using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberUtils;
using System;

namespace NumberUtilsTests
{
    [TestClass]
    public class NumberUtilsTests
    {
        [TestMethod]
        public void TestIsEven()
        {
            Func<int, bool> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            Assert.IsTrue(isEven(2));
            Assert.IsTrue(isEven(0));
            Assert.IsFalse(isEven(1));
            Assert.IsFalse(isEven(-1));
            Assert.IsTrue(isEven(-2));
        }
    }
}