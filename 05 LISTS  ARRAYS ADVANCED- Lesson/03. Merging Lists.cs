using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers1 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> numbers2 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<double> newNumbers = new List<double>();

            int length1 = numbers1.Count;
            int length2 = numbers2.Count;

            if (length1 < length2)
            {
                for(int i = 0; i<length1; i++)
                {
                    newNumbers.Add(numbers1[i]);
                    newNumbers.Add(numbers2[i]);
                }

                for(int j = length1; j < length2; j++)
                {
                    newNumbers.Add(numbers2[j]);
                }
            }
            else if(length1 == length2)
            {
                for (int i = 0; i < length1; i++)
                {
                    newNumbers.Add(numbers1[i]);
                    newNumbers.Add(numbers2[i]);
                }
            }
            else
            {
                for (int i = 0; i < length2; i++)
                {
                    newNumbers.Add(numbers1[i]);
                    newNumbers.Add(numbers2[i]);
                }

                for (int j = length2; j < length1; j++)
                {
                    newNumbers.Add(numbers1[j]);
                }
            }

            Console.WriteLine(string.Join(' ', newNumbers));
        }
    }
}
