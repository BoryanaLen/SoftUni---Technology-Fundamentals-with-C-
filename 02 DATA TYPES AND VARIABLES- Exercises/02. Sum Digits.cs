using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number = int.Parse(input);
            int lastNumber;
            int sum = 0;

            for(int i=0; i<input.Length; i++)
            {
                lastNumber = number % 10;

                sum += lastNumber;

                number = (number - lastNumber) / 10;
            }

            Console.WriteLine(sum);

        }
    }
}
