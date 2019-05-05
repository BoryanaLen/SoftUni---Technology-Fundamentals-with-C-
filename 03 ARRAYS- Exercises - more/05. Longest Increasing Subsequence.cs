using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] length = new int[input.Length];
            int[] prev = new int[input.Length];


            int maxLength = 0;
            int lastIndex = -1;         

            for (int i = 0; i<input.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (input[j] < input[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            List<int> longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(input[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();

            for(int a =0; a<longestSeq.Count; a++)
            {
                Console.Write($"{longestSeq[a]} ");
            }
        }
    }
}
