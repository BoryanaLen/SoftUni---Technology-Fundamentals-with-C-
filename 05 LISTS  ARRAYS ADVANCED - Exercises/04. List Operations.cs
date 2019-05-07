using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "End")
                {
                    Console.WriteLine(string.Join(' ', numbers));
                    break;
                }

                List<string> commands = command.Split(' ').ToList();

                if(commands[0] == "Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[2]);
                    int number = int.Parse(commands[1]);
                    
                    if(index<0 || index > (numbers.Count - 1))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (commands[0] == "Remove")
                {
                    int removePosition = int.Parse(commands[1]);

                    if(removePosition < 0|| removePosition > (numbers.Count - 1))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(removePosition);
                }
                else if (commands[1] == "left")
                {
                    int count = int.Parse(commands[2]);

                    for (int i = 0; i<count; i++)
                    {
                        int firstNumber = numbers[0];

                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }

                        numbers[numbers.Count - 1] = firstNumber;
                    }
                }
                else if (commands[1] == "right")
                {
                    int count = int.Parse(commands[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int lastNumber = numbers[numbers.Count - 1 ];

                        for (int j = (numbers.Count - 1); j > 0; j--)
                        {
                            numbers[j] = numbers[j-1];
                        }

                        numbers[0] = lastNumber;
                    }
                }
            }           
        }
    }
}
