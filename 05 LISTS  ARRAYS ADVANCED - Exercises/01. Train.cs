using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    Console.WriteLine(string.Join(' ',wagons));
                    break;
                }

                List<string> commands = command.Split(' ').ToList();

                if(commands[0] == "Add")
                {
                    wagons.Add(int.Parse(commands[1]));
                }
                else
                {
                    int passengers = int.Parse(commands[0]);

                    for(int i=0; i<wagons.Count; i++)
                    {
                        if ((wagons[i] + passengers) <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
        }
    }
}
