using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numner = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;

            for (int ch = 1; ch <= numner; ch++)
            {
                num = ch;

                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }

                if ( (sum == 5) || (sum == 7) || (sum == 11))
                {
                    Console.WriteLine($"{num} -> True");
                }
                else
                {
                    Console.WriteLine($"{num} -> False");
                }

                sum = 0;
                ch = num;
            }
        }
    }
}
