using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> countedList = new Dictionary<string, int>();
            int row = 0;
            string key = "";

            while (true)
            {
                string input = Console.ReadLine();
              
                if(input == "stop")
                {
                    foreach(var element in countedList)
                    {
                        Console.WriteLine($"{element.Key} -> {element.Value}");
                    }

                    break;
                }

                row++;

                if (row % 2 != 0)
                {
                    key = input;
                }
                else
                {
                    int number = int.Parse(input);

                    if (countedList.ContainsKey(key))
                    {
                        countedList[key] += number;
                    }
                    else
                    {
                        countedList.Add(key, number);
                    }                    
                }
            }
        }
    }
}
