using System;

namespace _10.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum;

            for(int i=1; i<=10; i++)
            {
                sum = i * number;

                Console.WriteLine($"{number} X {i} = {sum}");
            }
        }
    }
}
