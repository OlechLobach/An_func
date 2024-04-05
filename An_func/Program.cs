using System;
using System.Linq;

namespace LambdaExample
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };

            Func<int, bool> isPositive = x => x > 0;
            int count = numbers.Count(isPositive);

            Console.WriteLine($"Кількість позитивних чисел у масиві: {count}");
        }
    }
}