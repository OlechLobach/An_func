using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace OddNumbers.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void FindOddNumbers_ReturnsOddNumbers()
        {
            var findOddNumbers = new Func<int[], int[]>(array => array.Where(num => num % 2 != 0).ToArray());
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] oddNumbers = findOddNumbers(numbers);

            CollectionAssert.AreEqual(new int[] { 1, 3, 5, 7, 9 }, oddNumbers);
        }

        [TestMethod]
        public void FindOddNumbers_EmptyArray_ReturnsEmptyArray()
        {
            var findOddNumbers = new Func<int[], int[]>(array => array.Where(num => num % 2 != 0).ToArray());
            int[] numbers = { };

            int[] oddNumbers = findOddNumbers(numbers);

            CollectionAssert.AreEqual(new int[] { }, oddNumbers);
        }
    }
}