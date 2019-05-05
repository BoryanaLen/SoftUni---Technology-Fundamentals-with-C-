using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static double RectangleArea(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{RectangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()))}");
        }
    }
}
