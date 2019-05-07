using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayTimes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if(arrayTimes.Count > 1)
            {
                int countTimes = (arrayTimes.Count - 1) / 2;

                double timeLeft = 0;
                double timeRight = 0;

                for (int i = 0; i < countTimes; i++)
                {
                    if (arrayTimes[i] == 0)
                    {
                        timeLeft = timeLeft * 0.8;
                    }

                    if(arrayTimes[i] > 0)
                    {
                        timeLeft += arrayTimes[i];
                    }
                }

                for (int j = arrayTimes.Count - 1; j >= countTimes + 1; j--)
                {
                    if (arrayTimes[j] == 0)
                    {
                        timeRight = timeRight * 0.8;
                    }

                    if (arrayTimes[j] > 0)
                    {
                        timeRight += arrayTimes[j];
                    }                       
                }

                if (timeLeft < timeRight)
                {
                    Console.WriteLine($"The winner is left with total time: {timeLeft}");
                }
                else
                {
                    Console.WriteLine($"The winner is right with total time: {timeRight}");
                }
            }           
        }
    }
}
