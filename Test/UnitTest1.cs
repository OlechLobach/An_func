using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinInArray.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void FindMin_WithValidArray_ReturnsMinValue()
        {
            var findMin = new Func<int[], int>(array =>
            {
                if (array == null || array.Length == 0)
                {
                    throw new ArgumentException("Array is empty or null.");
                }

                int min = array[0];
                foreach (int num in array)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }

                return min;
            });

            int[] numbers = { 3, 7, 2, 9, 4, 1, 8, 6, 5 };

            int result = findMin(numbers);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindMin_WithEmptyArray_ThrowsArgumentException()
        {
            var findMin = new Func<int[], int>(array =>
            {
                if (array == null || array.Length == 0)
                {
                    throw new ArgumentException("Array is empty or null.");
                }

                int min = array[0];
                foreach (int num in array)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }

                return min;
            });

            int[] numbers = { };

            Assert.ThrowsException<ArgumentException>(() => findMin(numbers));
        }
    }
}