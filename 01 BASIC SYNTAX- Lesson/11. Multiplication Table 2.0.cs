using System;

namespace _11.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int mult = int.Parse(Console.ReadLine());
            int sum;


            if (mult <= 10)
            {
                for (int i = mult; i <= 10; i++)
                {
                    sum = i * number;

                    Console.WriteLine($"{number} X {i} = {sum}");
                }
            }
            else
            {
                sum = mult * number;

                Console.WriteLine($"{number} X {mult} = {sum}");
            }
        }
    }
}
