using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static string MultiplicationSign (int number1, int number2, int number3)
        {
            string result = string.Empty;

            int[] arrayNumbers = { number1, number2, number3 };

            if(number1 == 0 || number2 == 0 || number3 == 0)
            {
                result = "zero";
            }
            else
            {
                int counmNegative = 0;

                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    if (arrayNumbers[i] < 0)
                    {
                        counmNegative++;
                    }
                }

                if (counmNegative % 2 == 0)
                {
                    result = "positive";
                }
                else
                {
                    result = "negative";
                }

            }


            return result;
        }


        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplicationSign(num1, num2, num3));
        }
    }
}
