using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UniqueNegativeNumbers.Test
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void UniqueNegativeNumbers_ReturnsCorrectResult()
        {
            int[] numbers = { -1, 2, -3, 4, -5, 2, -7, 4, -9, 10 };

            var uniqueNegativeNumbers = numbers.Where(x => x < 0).Distinct().ToArray();

            Assert.AreEqual(5, uniqueNegativeNumbers.Length);
            Assert.IsTrue(uniqueNegativeNumbers.Contains(-1));
            Assert.IsTrue(uniqueNegativeNumbers.Contains(-3));
            Assert.IsTrue(uniqueNegativeNumbers.Contains(-5));
            Assert.IsTrue(uniqueNegativeNumbers.Contains(-7));
            Assert.IsTrue(uniqueNegativeNumbers.Contains(-9));
        }
    }
}