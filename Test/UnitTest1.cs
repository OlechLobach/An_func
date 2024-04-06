using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MaxInArray.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void FindMax_WithValidArray_ReturnsMaxValue()
        {
            var findMax = new Func<int[], int>(array =>
            {
                if (array == null || array.Length == 0)
                {
                    throw new ArgumentException("Array is empty or null.");
                }

                int max = array[0];
                foreach (int num in array)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }

                return max;
            });

            int[] numbers = { 3, 7, 2, 9, 4, 1, 8, 6, 5 };

            int result = findMax(numbers);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void FindMax_WithEmptyArray_ThrowsArgumentException()
        {
            var findMax = new Func<int[], int>(array =>
            {
                if (array == null || array.Length == 0)
                {
                    throw new ArgumentException("Array is empty or null.");
                }

                int max = array[0];
                foreach (int num in array)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }

                return max;
            });

            int[] numbers = { };

            Assert.ThrowsException<ArgumentException>(() => findMax(numbers));
        }
    }
}