using System;

namespace _03._Calculations
{
    class Program
    {
        static void SubstractNumbers(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void DivideNumbers(int a, int b)
        {
            Console.WriteLine(a / b);
        }


        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (input == "divide")
            {
                DivideNumbers(a, b);
            }
            else if(input== "subtract")
            {
                SubstractNumbers(a, b);
            }
            else if (input == "multiply")
            {
                MultiplyNumbers(a, b);
            }
            else if (input == "add")
            {
                AddNumbers(a, b);
            }
        }
    }
}
