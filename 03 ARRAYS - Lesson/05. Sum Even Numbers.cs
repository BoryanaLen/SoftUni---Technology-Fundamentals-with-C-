using System;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] textNumber = input.Split(' ');

            double[] numbers = Array.ConvertAll<string, double>(textNumber, double.Parse);

            double sum = 0;

            for(int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
