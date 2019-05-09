using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static int CharacterMultiplier(string one, string two)
        {
            int length = Math.Min(one.Length, two.Length);
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += one[i] * two[i];
            }

            if (one.Length > length)
            {
                for (int j = one.Length - 1; j >= length ; j--)
                {
                    sum += one[j];
                }
            }
            else if (two.Length > length)
            {
                for (int j = two.Length - 1; j >= length; j--)
                {
                    sum += two[j];
                }
            }

                return sum;
        }

        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string firstWord = input[0];
            string secondWord = input[1];

            Console.WriteLine(CharacterMultiplier(firstWord, secondWord));       
        }
    }
}
