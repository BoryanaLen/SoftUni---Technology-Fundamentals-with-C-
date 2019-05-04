using System;

namespace _12.Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
