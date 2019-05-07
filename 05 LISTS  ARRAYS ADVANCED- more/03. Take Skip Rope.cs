using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string resultDidits = string.Empty;

            List<int> takeList = new List<int>();

            List<int> skipList = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    resultDidits += input[i];
                    input = input.Remove(i, 1);
                    i -= 1;
                }
            }

            for(int j = 0; j<resultDidits.Length; j++)
            {
                if (j % 2 == 0)
                {
                    takeList.Add(resultDidits[j] - '0');
                }
                else
                {
                    skipList.Add(resultDidits[j] - '0');
                }
            }

            string resultString = string.Empty;

            for(int a = 0; a<takeList.Count; a++)
            {
                if(takeList[a] > input.Length)
                {
                    takeList[a] = input.Length;
                }

                resultString += input.Substring(0, takeList[a]);

                int totalLength = takeList[a] + skipList[a];

                if(totalLength > input.Length)
                {
                    totalLength = input.Length;
                }

                input = input.Remove(0, totalLength);
            }

            Console.WriteLine(resultString);
        }
    }
}
