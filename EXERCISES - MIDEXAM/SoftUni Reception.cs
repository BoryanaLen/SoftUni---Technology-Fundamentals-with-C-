using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int countFirst = int.Parse(Console.ReadLine());
            int countSecond = int.Parse(Console.ReadLine());
            int countThird = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int totalStudentsForHour = countFirst + countSecond + countThird;
            int hours = 0;

            while (students > 0)
            {
                students -= totalStudentsForHour;

                hours++;

                if (hours % 4 == 0 && hours !=0)
                {
                    hours++;
                    continue;
                }
                
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
