using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = int.Parse(input);
            int number;
            int multNumber = 1;
            int totalSum = 0;
           
            foreach(char a in input)
            {
                number = a - '0';

                for(int i=1; i <= number; i++)
                {
                    multNumber *= i;
                }

                totalSum += multNumber;
                multNumber = 1;
            }

            if (totalSum == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
