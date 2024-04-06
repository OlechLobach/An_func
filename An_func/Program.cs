using System;

namespace NumberUtils
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            int numberToCheck = 10;

            if (isEven(numberToCheck))
            {
                Console.WriteLine($"{numberToCheck} is even.");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} is odd.");
            }
        }
    }
}