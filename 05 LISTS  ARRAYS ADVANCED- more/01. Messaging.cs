using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();

            string result = string.Empty;

            for(int i =0; i<listOfNumbers.Count; i++)
            {
                int number = listOfNumbers[i];
                int sum = 0;

                while (true)
                {
                    int lastNumber = number % 10;
                    sum += lastNumber;
                    number = (number - lastNumber) / 10;

                    if (number <= 0)
                    {
                        sum += number;
                        break;
                    }
                }

                if (sum <= (input.Length - 1))
                {
                    result += input[sum];
                }
                else
                {
                    while (sum > (input.Length - 1))
                    {
                        sum -= input.Length ;
                    }

                    result += input[sum];
                }

                input = input.Remove((sum - 1), 1);
            }

            Console.WriteLine(result);
        }
    }
}
