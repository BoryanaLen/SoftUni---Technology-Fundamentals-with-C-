using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int[] maxSequences = null;
           
            int maxCount = 0;
            int maxSum = 0;
            int maxLeftIndex = int.MaxValue;
            int maxNumberLines = 0;
            int numberLines = 0;

            while (true)
            {
                string input = Console.ReadLine();
               
                if (input== "Clone them!")
                {
                    break;
                }

                int[] sequences = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (sequences.Length != dnaLength)
                {
                    continue;
                }

                numberLines++;

                int count = 0;
                int maxCurrentCount = 0;
                int currentSum = 0;
                int maxCurrentLeftIndex = dnaLength;
                int leftIndex = dnaLength;

                for (int i = 0; i < sequences.Length; i++)
                {
                    currentSum += sequences[i];

                    if(sequences[i] == 1)
                    {
                        if (count == 0)
                        {
                            leftIndex = i;
                        }

                        count++;
                    }
                    else
                    {
                        count = 0;
                    }

                    if (count > maxCurrentCount)
                    {
                        maxCurrentCount = count;
                        maxCurrentLeftIndex = leftIndex;
                    }
                }

                if (maxCurrentCount > maxCount)
                {
                    maxCount = maxCurrentCount;
                    maxSum = currentSum;
                    maxNumberLines = numberLines;
                    maxLeftIndex = maxCurrentLeftIndex;
                    maxSequences = sequences;
                }
                else if (maxCurrentCount == maxCount && maxCurrentLeftIndex < maxLeftIndex)
                {
                    maxSum = currentSum;
                    maxLeftIndex = maxCurrentLeftIndex;
                    maxNumberLines = numberLines;
                    maxSequences = sequences;
                }
                else if(maxCurrentCount == maxCount && maxCurrentLeftIndex == maxLeftIndex && currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxNumberLines = numberLines;
                    maxSequences = sequences;
                }
            }


            Console.WriteLine($"Best DNA sample {maxNumberLines} with sum: {maxSum}.");

            for (int i = 0; i < maxSequences.Length; i++)
            {
                Console.Write($"{maxSequences[i]} ");
            }

            
        }
    }
}
