using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static int SumIntegers (int a, int b)
        {
            return a + b;
        }

        static int SubstractIntegers (int a, int b, int c)
        {
            int sum = SumIntegers(a, b);

            return sum - c;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(SubstractIntegers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
    }
}
