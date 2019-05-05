using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] firstArray = new int [input.Length/2];
            int[] secondArray = new int[input.Length / 2];

            int k = input.Length / 4;
            int index2 = 0;
            int index1 = 0;

            for (int a = k; a < input.Length - k; a++)
            {
                secondArray[index2] = input[a];
                index2++;
            }

            for(int b = (k-1); b>=0; b--)
            {
                firstArray[index1] = input[b];
                index1++;
            }


            for (int c = input.Length-1; c >= input.Length-k; c--)
            {
                firstArray[index1] = input[c];
                index1++;
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                int sum = firstArray[i] + secondArray[i];

                Console.Write($"{sum} ");
            }
      
        }
    }
}
