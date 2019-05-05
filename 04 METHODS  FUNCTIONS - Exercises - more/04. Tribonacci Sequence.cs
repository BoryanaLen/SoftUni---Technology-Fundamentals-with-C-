using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static string TribonacciSequence(int number)
        {
            string result = string.Empty;

            int[] arrayNumbers = new int[number];

            if(number == 1)
            {
                arrayNumbers[0] = 1;
            }
            else if(number == 2)
            {
                arrayNumbers[0] = 1;
                arrayNumbers[1] = 1;
            }
            else if (number == 3)
            {
                arrayNumbers[0] = 1;
                arrayNumbers[1] = 1;
                arrayNumbers[2] = 2;
            }
            else
            {
                arrayNumbers[0] = 1;
                arrayNumbers[1] = 1;
                arrayNumbers[2] = 2;

                for (int i = 3; i < arrayNumbers.Length; i++)
                {
                    arrayNumbers[i] = arrayNumbers[i - 1] + arrayNumbers[i - 2] + arrayNumbers[i - 3];
                }
            }

            result = string.Join(' ', arrayNumbers);

            return result;
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(TribonacciSequence(num));
        }
    }
}
