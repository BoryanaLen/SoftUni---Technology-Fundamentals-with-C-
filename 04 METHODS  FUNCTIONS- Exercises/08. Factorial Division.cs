using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static double CalculateFactorial(double number)
        {
            double result = number;

            for(double i = number-1; i>=1; i--)
            {
                result *= i;
            }

            return result;
        }

        static double DivideNumbers(double a, double b)
        {
            double firstNumber = CalculateFactorial(a);
            double secondNumber = CalculateFactorial(b);

            double result = firstNumber / secondNumber;

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"{(DivideNumbers(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()))):F2}");
        }
    }
}
