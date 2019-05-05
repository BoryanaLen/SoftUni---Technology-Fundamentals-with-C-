using System;

namespace _10._Top_Number
{
    class Program
    {
        static bool IsDivideEight(int number)
        {
            int sum = 0;

            while (true)
            {
                if (number <= 9)
                {
                    sum += number;
                    break;
                }

                int lastNumber = number % 10;

                sum += lastNumber;

                number = (number - lastNumber) / 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool IsOddNumber(int number)
        {
            while (number > 0)
            {
                int lastNumber = number % 10;

                if (lastNumber % 2 != 0)
                {
                    return true;
                }

                number = (number - lastNumber) / 10;
            }

            return false;
        }

        static void PrintMasterNumbers(int inputNumber)
        {
            for (int i = 1; i <= inputNumber; i++)
            {
                if (IsOddNumber(i) == true && IsDivideEight(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            PrintMasterNumbers(int.Parse(Console.ReadLine()));
        }
    }
}
