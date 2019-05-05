using System;

namespace _04._Printing_Triangle
{
    class Program
    {
 
        static void PrintTriangle(int number)
        {
            for(int i =1; i<=number; i++)
            {
                for(int j = 1; j<=i; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }

            int count = number;

            for (int i = 1; i <= (number-1); i++)
            {

                for (int j = 1; j <= (count-1); j++)
                {
                    Console.Write($"{j} ");                   
                }

                count -= 1;

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }
    }
}
