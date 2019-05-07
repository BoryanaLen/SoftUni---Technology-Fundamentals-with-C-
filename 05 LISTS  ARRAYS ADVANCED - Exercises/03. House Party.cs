using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCommands = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < numberCommands; i++)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();

                if (commands[2] == "going!")
                {
                    int countSame = 0;

                    for (int j = 0; j < names.Count; j++)
                    {
                        if (names[j] == commands[0])
                        {
                            Console.WriteLine($"{commands[0]} is already in the list!");
                            countSame++;
                            break;
                        }
                    }

                    if (countSame == 0)
                    {
                        names.Add(commands[0]);
                    }
                }
                else if (commands[2] == "not")
                {
                    int countSame = 0;

                    for (int j = 0; j < names.Count; j++)
                    {
                        if (names[j] == commands[0])
                        {
                            names.RemoveAt(j);
                            countSame++;
                            break;
                        }
                    }

                    if (countSame == 0)
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
            }

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
