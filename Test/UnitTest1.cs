using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberUtils;
using System;

namespace NumberUtilsTests
{
    [TestClass]
    public class SquareMethodTests
    {
        [TestMethod]
        public void TestSquareMethod()
        {
            Func<int, int> square = delegate (int number)
            {
                return number * number;
            };

            int result = square(5);

            Assert.AreEqual(25, result);
        }
    }
}