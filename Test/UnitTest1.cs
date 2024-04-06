using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CubeCalculator.Tests
{
    [TestClass]
    public class CubeCalculatorTests
    {
        [TestMethod]
        public void CubeCalculator_CalculatesCubeOfNumber()
        {
            Func<int, int> cube = x => x * x * x;

            int result = cube(3);

            Assert.AreEqual(27, result);
        }
    }
}