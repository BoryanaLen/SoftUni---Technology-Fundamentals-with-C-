using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            int length = numbers.Count;

            List<double> newNumbers = new List<double>();

            if (length % 2 == 0)
            {
                for(int i = 0; i<length/2; i++)
                {
                    double sum = numbers[i] + numbers[length - 1 - i];

                    newNumbers.Add(sum);
                }
            }
            else
            {
                for (int i = 0; i < length / 2; i++)
                {
                    double sum = numbers[i] + numbers[length - 1 - i];

                    newNumbers.Add(sum);
                }

                newNumbers.Add(numbers[(length - 1) / 2]);
            }

            Console.WriteLine(string.Join(' ', newNumbers));
        }
    }
}
