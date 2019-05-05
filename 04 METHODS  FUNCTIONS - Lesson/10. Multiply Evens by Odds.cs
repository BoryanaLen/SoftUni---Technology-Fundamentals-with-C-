using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static int GetSumOfEvenDigits(int numberEven)
        {
            int sum = 0;

            int number = Math.Abs(numberEven);

            int lastNumber;

            while (true)
            {
                lastNumber = number % 10;

                if (lastNumber % 2 == 0)
                {
                    sum += lastNumber;
                }

                number = (number - lastNumber) / 10;

                if (number <= 9)
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                    }

                    break;
                }
            }

            return sum;
        }

        static int GetSumOfOddDigits(int numberOdd)
        {
            int sum = 0;

            int number = Math.Abs(numberOdd);


            while (true)
            {
                int lastNumber = number % 10;

                if (lastNumber % 2 != 0)
                {
                    sum += lastNumber;
                }

                number = (number - lastNumber) / 10;

                if (number <= 9)
                {
                    if (number % 2 != 0)
                    {
                        sum += number;
                    }

                    break;
                }
            }

            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int sumEven, int sumOdd)
        {
            return sumEven * sumOdd;
        }


        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(inputNumber), GetSumOfOddDigits(inputNumber));

            Console.WriteLine(result);
           
        }
    }
}
