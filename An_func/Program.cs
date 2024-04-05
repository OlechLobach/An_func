using System;

namespace LambdaExpressionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, bool> containsWord = (text, word) => text.Contains(word);

            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();

            Console.WriteLine("Enter a word to check:");
            string word = Console.ReadLine();

            bool result = containsWord(text, word);
            Console.WriteLine($"The text {(result ? "contains" : "does not contain")} the word '{word}'.");

            Console.ReadKey();
        }
    }
}