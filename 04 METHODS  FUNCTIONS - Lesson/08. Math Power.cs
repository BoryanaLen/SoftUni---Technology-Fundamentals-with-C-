using System;

namespace _08._Math_Power
{
    class Program
    {
        static double PowNumber(double number, int pow)
        {
            return Math.Pow(number, pow);
        }

        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine($"{PowNumber(number,pow)}");
        }
    }
}
