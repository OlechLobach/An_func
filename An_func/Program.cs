using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { -1, 2, -3, 4, -5, 2, -7, 4, -9, 10 };

        var uniqueNegativeNumbers = numbers.Where(x => x < 0).Distinct();

        foreach (var number in uniqueNegativeNumbers)
        {
            Console.WriteLine(number);
        }
    }
}