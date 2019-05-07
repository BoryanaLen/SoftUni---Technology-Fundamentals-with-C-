using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    Console.WriteLine(string.Join(' ', numbers));
                    break;
                }

                List<string> commands = command.Split(' ').ToList();

                if(commands[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if(numbers[i] == int.Parse(commands[1]))
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int position = int.Parse(commands[2]);
                    int numberToInsert = int.Parse(commands[1]);

                    numbers.Insert(position, numberToInsert);
                }
            }
        }
    }
}
