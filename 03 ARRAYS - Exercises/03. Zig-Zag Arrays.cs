using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            int[] arrayOne = new int [number];
            int[] arrayTwo = new int[number];

            if (number > 0)
            {
                int indexOne = 0;
                int indexTwo = 0;

                for (int i = 0; i < number; i++)
                {
                    int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    count++;

                    if (count % 2 == 0)
                    {
                        arrayOne[indexOne] = inputArray[1];
                        indexOne++;
                        arrayTwo[indexTwo] = inputArray[0];
                        indexTwo++;
                    }
                    else
                    {
                        arrayOne[indexOne] = inputArray[0];
                        indexOne++;
                        arrayTwo[indexTwo] = inputArray[1];
                        indexTwo++;
                    }
                }

                for (int i = 0; i < arrayOne.Length; i++)
                {
                    Console.Write($"{arrayOne[i]} ");
                }

                Console.WriteLine();

                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    Console.Write($"{arrayTwo[i]} ");
                }
            }
        }            
    }
}
