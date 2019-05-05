using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int maxCount = 0;
            int number = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if(i == (inputArray.Length - 1))
                {
                    break;
                }

                if(inputArray[i] == inputArray[i + 1])
                {
                    count++;
                }

                else
                {
                    count = 0;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    number = inputArray[i];
                }
            }

            if (maxCount != 0)
            {
                for (int j = 0; j <= maxCount; j++)
                {
                    Console.Write($"{number} ");
                }
            }          
        }
    }
}
