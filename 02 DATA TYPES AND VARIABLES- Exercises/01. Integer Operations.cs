using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int divide = int.Parse(Console.ReadLine());
            int mult = int.Parse(Console.ReadLine());

            int result = (a + b) / divide * mult;

            Console.WriteLine(result);
        }
    }
}
