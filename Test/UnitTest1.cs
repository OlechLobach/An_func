using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace LambdaExample.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CountPositiveNumbers_ArrayWithPositiveNumbers_ReturnsCorrectCount()
        {
            int[] numbers = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };
            Func<int, bool> isPositive = x => x > 0;

            int count = numbers.Count(isPositive);

            Assert.AreEqual(5, count); 
        }

        [TestMethod]
        public void CountPositiveNumbers_ArrayWithoutPositiveNumbers_ReturnsZero()
        {
            int[] numbers = { -1, -2, -3, -4, -5 };

            Func<int, bool> isPositive = x => x > 0;
            int count = numbers.Count(isPositive);

            Assert.AreEqual(0, count); 
        }
    }
}