using System;

namespace ProgrammerDayCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> isProgrammersDay = dayOfYear => dayOfYear == 256;

            Console.WriteLine("Enter a day of the year (1-365):");
            if (int.TryParse(Console.ReadLine(), out int day))
            {
                if (isProgrammersDay(day))
                {
                    Console.WriteLine("Programmer's Day!");
                }
                else
                {
                    Console.WriteLine("Not Programmer's Day.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadKey();
        }
    }
}