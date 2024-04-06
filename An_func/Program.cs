using System;

namespace MinInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> findMin = array =>
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
            };

            int[] numbers = { 3, 7, 2, 9, 4, 1, 8, 6, 5 };

            try
            {
                int min = findMin(numbers);
                Console.WriteLine($"The minimum value in the array is: {min}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}