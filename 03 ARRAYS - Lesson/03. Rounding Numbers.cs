using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] textNumbers = input.Split(' ');

            double[] convertedNumbers = Array.ConvertAll<string, double>(textNumbers, double.Parse);

            for(int i=0; i<convertedNumbers.Length; i++)
            {
                Console.WriteLine($"{convertedNumbers[i]} => {Math.Round(convertedNumbers[i], 0, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
