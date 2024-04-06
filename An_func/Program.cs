using System;

namespace MaxInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> findMax = array =>
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
            };

            int[] numbers = { 3, 7, 2, 9, 4, 1, 8, 6, 5 };
            Console.WriteLine("Array: " + string.Join(", ", numbers));
            Console.WriteLine("Maximum: " + findMax(numbers));

            Console.ReadKey();
        }
    }
}