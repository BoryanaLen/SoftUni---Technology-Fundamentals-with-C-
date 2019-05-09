using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split('@').Select(int.Parse).ToList();

            int lastPosition = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Merry Xmas!")
                {
                    break;
                }

                List<string> commandInfo = input.Split(' ').ToList();

                int length = int.Parse(commandInfo[1]);

                int totalLength = length + lastPosition;

                if (length >= 0)
                {
                    if (totalLength >= numbers.Count)
                    {
                        while ((totalLength) >= numbers.Count)
                        {
                            totalLength -= numbers.Count;
                        }
                    }

                    if (numbers[totalLength] == 0)
                    {
                        Console.WriteLine($"House {totalLength} will have a Merry Christmas.");
                    }
                    else
                    {
                        numbers[totalLength] -= 2;
                    }

                    lastPosition = totalLength;
                }
            }

            Console.WriteLine($"Santa's last position was {lastPosition}.");

            int sumNumbers = numbers.Sum();
            List<int> notNull = numbers.Where(x => x > 0).ToList();

            if(sumNumbers == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {notNull.Count} houses.");
            }
        }
    }
}
