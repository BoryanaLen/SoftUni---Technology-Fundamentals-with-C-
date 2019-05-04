using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            int liters;
            int capacity = 255;
            int total = 0;

            for(int i = 0; i < numberLines; i++)
            {
                liters = int.Parse(Console.ReadLine());

                if (liters > (capacity-total))
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    total += liters;
                }
            }

            Console.WriteLine(total);
        }
    }
}
