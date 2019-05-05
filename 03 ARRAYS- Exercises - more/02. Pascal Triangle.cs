using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(1);

            if (inputNumber > 1)
            {
                long [] rowTwo = new long [] { 1, 1 };

                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{rowTwo[j]} ");
                }

                Console.WriteLine();

                long [] nextRow = rowTwo;

                for (int i = 2; i < inputNumber; i++)
                {
                    long[] currentRow = new long[nextRow.Length + 1];
                    currentRow[0] = 1;
                    currentRow[nextRow.Length] = 1;

                    for (int a = 1; a <= currentRow.Length - 2; a++)
                    {
                        currentRow[a] = nextRow[a - 1] + nextRow[a];
                    }

                    for (int j = 0; j < currentRow.Length; j++)
                    {
                        Console.Write($"{currentRow[j]} ");
                    }

                    Console.WriteLine();

                    nextRow = currentRow;
                }

            }

        }
    }
}
