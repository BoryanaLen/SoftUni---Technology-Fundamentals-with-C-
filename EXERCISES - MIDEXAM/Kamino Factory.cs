using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            if (length <= 0)
            {
                return;
            }

            int maxSum = int.MinValue;
            int maxCount = 0;
            int maxLeftIndex = -1;
            int maxLineSeq = 0;
            List<int> maxSeq = new List<int>();
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();              

                if (input == "Clone them!")
                {
                    Console.WriteLine($"Best DNA sample {maxLineSeq} with sum: {maxSum}.");
                    Console.WriteLine(string.Join(' ', maxSeq));
                    break;
                }

                count++;

                List<int> inputDNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                int currentCount = 0;
                int maxCurrentCount = 0;
                int maxCurrentIndex = -1;
                int currentStartIndex = -1;
               
                for (int i = 0; i < length; i++)
                {
                    if(inputDNA[i] == 1)
                    {
                        if (currentCount == 0)
                        {
                            currentStartIndex = i;
                        }

                        currentCount++;

                        if(currentCount > maxCurrentCount)
                        {
                            maxCurrentCount = currentCount;
                            maxCurrentIndex = currentStartIndex;
                        }
                    }
                    else
                    {
                        currentCount = 0;
                        currentStartIndex = -1;
                    }
                }

                int currentSum = inputDNA.Sum();

                if(maxCurrentCount > maxCount)
                {
                    maxCount = maxCurrentCount;
                    maxSum = currentSum;
                    maxSeq = inputDNA;
                    maxLeftIndex = maxCurrentIndex;
                    maxLineSeq = count;
                }
                else if (maxCurrentCount == maxCount && maxLeftIndex > maxCurrentIndex)
                {
                    maxCount = maxCurrentCount;
                    maxSum = currentSum;
                    maxSeq = inputDNA;
                    maxLeftIndex = maxCurrentIndex;
                    maxLineSeq = count;
                }
                else if (maxCurrentCount == maxCount && maxLeftIndex == maxCurrentIndex && currentSum > maxSum)
                {
                    maxCount = maxCurrentCount;
                    maxSum = currentSum;
                    maxSeq = inputDNA;
                    maxLeftIndex = maxCurrentIndex;
                    maxLineSeq = count;
                }
            }
        }
    }
}
