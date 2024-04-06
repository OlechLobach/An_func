using System;

namespace NumberUtils
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = delegate (int number)
            {
                return number * number;
            };

            int result = square(5);
            Console.WriteLine(result);
        }
    }
}