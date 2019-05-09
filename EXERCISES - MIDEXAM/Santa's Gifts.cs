using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCommands = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int startPosition = 0;

            for (int i = 0; i < numberCommands; i++)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();
                string command = commands[0];

                if(command == "Forward")
                {
                    int steps = int.Parse(commands[1]);

                    if ((startPosition + steps) < numbers.Count)
                    {
                        numbers.RemoveAt(startPosition + steps);
                        startPosition += steps;
                    }                    
                }
                else if(command == "Back")
                {
                    int steps = int.Parse(commands[1]);

                    if ((startPosition - steps) >= 0)
                    {
                        numbers.RemoveAt(startPosition - steps);
                        startPosition -= steps;
                    }                       
                }
                else if(command == "Gift")
                {
                    int steps = int.Parse(commands[1]);
                    if (steps >= 0 && steps < numbers.Count)
                    {
                        numbers.Insert(steps, int.Parse(commands[2]));
                        startPosition = steps;
                    }                 
                }
                else if (command == "Swap")
                {
                    int value1 = int.Parse(commands[1]);
                    int value2 = int.Parse(commands[2]);
                    int position1 = -1;
                    int position2 = -1;

                    for (int a = 0; a < numbers.Count; a++)
                    {
                        if(numbers[a] == value1)
                        {
                            position1 = a;
                        }
                        else if(numbers[a] == value2)
                        {
                            position2 = a;
                        }
                    }

                    if (position1 != -1 && position2 != -1)
                    {
                        numbers[position1] = value2;
                        numbers[position2] = value1;
                    }                  
                }
            }

            Console.WriteLine($"Position: {startPosition}");

            Console.WriteLine($"{string.Join(", ", numbers)}");
        }
    }
}
