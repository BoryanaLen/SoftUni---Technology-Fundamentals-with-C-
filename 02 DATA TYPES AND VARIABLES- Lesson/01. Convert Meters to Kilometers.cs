using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double kilom = number / 1000.00;

            Console.WriteLine($"{kilom:F2}");
        }
    }
}
