using System;
using System.Linq;

namespace LambdaExample
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 7, 14, 21, 8, 9, 10, 28, 35, 42, 49 };

            Func<int, bool> isMultipleOfSeven = x => x % 7 == 0;
            int count = numbers.Count(isMultipleOfSeven);

            Console.WriteLine($"Кількість чисел, кратних семи, у масиві: {count}");
        }
    }
}