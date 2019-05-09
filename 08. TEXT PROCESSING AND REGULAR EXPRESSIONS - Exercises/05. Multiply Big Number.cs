using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            int numberForPrevious = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentNumber = (int)char.GetNumericValue(bigNumber[i]);
                int result = currentNumber * number + numberForPrevious;

                if (result > 9)
                {
                    int lastNumber = result % 10;
                    numberForPrevious = result / 10;
                    result = lastNumber;
                }
                else
                {
                    numberForPrevious = 0;
                }

                sb.Insert(0, result);

                if (i == 0 && numberForPrevious > 0)
                {
                    sb.Insert(0, numberForPrevious);
                }
            }

            var finalResult = sb.ToString().TrimStart('0');

            Console.WriteLine(finalResult);
        }
    }
}
