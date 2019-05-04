using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char input;
            int sum = 0;

            for(int i=0; i < n; i++)
            {
                input = char.Parse(Console.ReadLine());

                sum += input;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
