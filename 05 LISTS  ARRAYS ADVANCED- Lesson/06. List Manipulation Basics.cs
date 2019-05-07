using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    Console.WriteLine(string.Join(' ', numbers));
                    break;
                }

                List<string> commands = command.Split(' ').ToList();

                if(commands[0] == "Add")
                {
                    numbers.Add(double.Parse(commands[1]));
                }
                else if(commands[0] == "Remove")
                {
                    numbers.Remove(double.Parse(commands[1]));
                }
                else if (commands[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), double.Parse(commands[1]));
                }
            }
        }
    }
}
