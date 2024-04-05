using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace LambdaExample.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] numbers = { 7, 14, 21, 8, 9, 10, 28, 35, 42, 49 };
            Func<int, bool> isMultipleOfSeven = x => x % 7 == 0;

            int count = numbers.Count(isMultipleOfSeven);

            Assert.AreEqual(5, count); 
        }
    }
}