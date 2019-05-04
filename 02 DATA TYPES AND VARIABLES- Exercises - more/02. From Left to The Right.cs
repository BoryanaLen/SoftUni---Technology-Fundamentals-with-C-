using System;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberLines; i++)
            {
                string input = Console.ReadLine();
             
                string one = input.Split(" ")[0];
                string two = input.Split(" ")[1];

                BigInteger numberOne = BigInteger.Parse(one);
                BigInteger numberTwo = BigInteger.Parse(two);

                int length;
                BigInteger maxValue;

                if (numberOne > numberTwo)
                {
                    maxValue = numberOne;
                    length = one.Length;
                }
                else
                {
                    maxValue = numberTwo;
                    length = two.Length;
                }

                BigInteger lastNumber;
                int sum = 0;
                BigInteger number = BigInteger.Abs(maxValue);

                for (int a = 0; a < length; a++)
                {
                    lastNumber = number % 10;

                    sum += (int)lastNumber;

                    number = (number - lastNumber) / 10;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
