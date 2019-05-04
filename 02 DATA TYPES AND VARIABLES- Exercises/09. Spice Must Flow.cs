using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine()) ;
            int days = 0;
            int sum = 0;

            while (true)
            {
                if (startingYield < 100)
                {
                    if (days != 0)
                    {
                        sum -= 26;
                    }
                    
                    break;
                }

                days++;
                sum += startingYield -26;
                startingYield -= 10;
            }

            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}
