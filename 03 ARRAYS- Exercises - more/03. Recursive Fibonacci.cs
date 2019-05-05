using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                long[] numbers = new long[inputNumber];

                numbers[0] = 1;
                numbers[1] = 1;

                for (int i = 2; i <= inputNumber - 1; i++)
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                }

                Console.WriteLine($"{numbers[inputNumber - 1]}");
            }            
        }
    }
}
