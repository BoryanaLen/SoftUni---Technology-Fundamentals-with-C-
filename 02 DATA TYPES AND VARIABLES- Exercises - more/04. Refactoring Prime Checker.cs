using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                int count = 0;

                for (int a = 2; a <= i; a++)
                {
                    if (i % a == 0)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    Console.WriteLine($"{i} -> true");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");
                }              
            }
        }
    }
}
