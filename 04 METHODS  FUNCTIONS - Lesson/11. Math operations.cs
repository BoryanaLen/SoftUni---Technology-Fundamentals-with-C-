using System;

namespace _11._Math_operations
{
    class Program
    {
        static double Divide (double a, double b)
        {
            return a / b;
        }

        static double Mult(double a, double b)
        {
            return a * b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Substract (double a, double b)
        {
            return a - b;
        }

        static double Result(double a, char symbol, double b)
        {
            double result = 0;

            switch (symbol)
            {
                case '/':
                    result= Divide(a, b);
                    break;
                case '+':
                    result = Add(a, b);
                    break;
                case '*':
                    result = Mult(a, b);
                    break;
                case '-':
                    result = Substract(a, b);
                    break;
            }

            return result;
        }

        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            Console.WriteLine(Result(numberOne, symbol, numberTwo));
        }
    }
}
