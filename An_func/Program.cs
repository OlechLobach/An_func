using System;

namespace CubeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> cube = x => x * x * x;

            int number = 5;
            int result = cube(number);
            Console.WriteLine($"Cube of {number} is {result}");
        }
    }
}