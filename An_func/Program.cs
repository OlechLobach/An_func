using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> findOddNumbers = array =>
            {
                int count = 0;
                foreach (int num in array)
                {
                    if (num % 2 != 0)
                    {
                        count++;
                    }
                }

                int[] oddNumbers = new int[count];
                int index = 0;
                foreach (int num in array)
                {
                    if (num % 2 != 0)
                    {
                        oddNumbers[index] = num;
                        index++;
                    }
                }

                return oddNumbers;
            };

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] oddNumbers = findOddNumbers(numbers);

            Console.WriteLine("Odd numbers in the array:");
            foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}