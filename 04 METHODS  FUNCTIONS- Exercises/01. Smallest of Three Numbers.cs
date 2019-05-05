using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static double PrintSmallestNumber(double numberOne, double numberTwo, double numberThree)
        {
            double smallestNumber = double.MaxValue;

            double[] numbers = { numberOne, numberTwo, numberThree };

            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }
            }

            return smallestNumber;
        }

        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(PrintSmallestNumber(firstNumber,secondNumber,thirdNumber));
        }
    }
}
