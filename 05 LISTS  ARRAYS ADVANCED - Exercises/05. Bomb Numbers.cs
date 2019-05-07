using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            List<int> bombNumberAndPower = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            int bombNumber = bombNumberAndPower[0];
            int power = bombNumberAndPower[1];
            int powerRight = power;
            int powerLeft = power;

            for(int i=0; i<numbers.Count; i++)
            {
                if(numbers[i] == bombNumber)
                {
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, numbers.Count - 1);

                    int lenght = right - left + 1;

                    numbers.RemoveRange(left, lenght);

                    i = 0;
                }
            }

            int sum = 0;

            foreach(int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
