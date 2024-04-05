using System;



namespace RainbowColors
{
    public enum Color
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a color from the rainbow:");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Color color))
            {
                Program program = new Program();
                var rgb = program.GetRgbValue(color);
                Console.WriteLine($"RGB values for {color}: ({rgb.Item1}, {rgb.Item2}, {rgb.Item3})");
            }
            else
            {
                Console.WriteLine("Invalid color entered.");
            }

            Console.ReadKey();
        }

        public (int, int, int) GetRgbValue(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    return (255, 0, 0);
                case Color.Orange:
                    return (255, 165, 0);
                case Color.Yellow:
                    return (255, 255, 0);
                case Color.Green:
                    return (0, 128, 0);
                case Color.Blue:
                    return (0, 0, 255);
                case Color.Indigo:
                    return (75, 0, 130);
                case Color.Violet:
                    return (238, 130, 238);
                default:
                    throw new ArgumentException("Invalid color");
            }
        }
    }
}