using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberWagons = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberWagons];
            int sum = 0;

            for(int i = 0; i < numberWagons; i++)
            {
                int input = int.Parse(Console.ReadLine());

                numbers[i] = input;
                sum += input;
            }

            for(int j=0; j<numbers.Length; j++)
            {
                Console.Write($"{numbers[j]} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
