using System;

namespace _09.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0;


            for(int i=1; ; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                    count += 1;
                }

                if (count == n)
                {
                    break;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
