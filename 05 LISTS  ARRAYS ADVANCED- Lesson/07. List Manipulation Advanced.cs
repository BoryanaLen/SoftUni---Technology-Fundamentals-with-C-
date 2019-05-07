using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    if (count != 0)
                    {
                        Console.WriteLine(string.Join(' ', numbers));
                    }
                    
                    break;
                }

                List<string> commands = command.Split(' ').ToList();

                if (commands[0] == "Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                    count++;
                }
                else if (commands[0] == "Remove")
                {
                    numbers.Remove(int.Parse(commands[1]));
                    count++;
                }
                else if (commands[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                    count++;
                }
                else if (commands[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    count++;
                }
                else if (commands[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(commands[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commands[0] == "PrintEven")
                {
                    List<int> evenNumbers = new List<int>();

                    for(int i = 0; i<numbers.Count;i++)
                    {
                        if(numbers[i]%2 == 0)
                        {
                            evenNumbers.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(' ', evenNumbers));
                }
                else if (commands[0] == "PrintOdd")
                {
                    List<int> oddNumbers = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            oddNumbers.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(' ', oddNumbers));
                }
                else if (commands[0] == "GetSum")
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine(sum);
                }
                else if (commands[0] == "Filter")
                {
                    List<int> newNumbers = new List<int>();


                    if (commands[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= int.Parse(commands[2]))
                            {
                                newNumbers.Add(numbers[i]);
                            }
                        }
                    }
                    else if (commands[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= int.Parse(commands[2]))
                            {
                                newNumbers.Add(numbers[i]);
                            }
                        }
                    }
                    else if(char.Parse(commands[1]) == '<')
                    {
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < int.Parse(commands[2]))
                            {
                                newNumbers.Add(numbers[i]);
                            }
                        }
                    }
                    else if (char.Parse(commands[1]) == '>')
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > int.Parse(commands[2]))
                            {
                                newNumbers.Add(numbers[i]);
                            }
                        }
                    }
                   

                    Console.WriteLine(string.Join(' ', newNumbers));
                }
            }
        }
    }
}
