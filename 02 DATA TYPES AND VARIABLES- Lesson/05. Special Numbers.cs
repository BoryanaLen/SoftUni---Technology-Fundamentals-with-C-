using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            
            for(int i=1; i<=inputNumber; i++)
            {
                int sum = 0;

                if (i < 10)
                {
                    sum += i;
                }
                else
                {
                    int num = i;

                    while (true)
                    {
                        int lastNumber = num % 10;

                        sum += lastNumber;

                        num = (num - lastNumber) / 10;

                        if (num < 10)
                        {
                            sum += num;
                            break;
                        }

                    }
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
