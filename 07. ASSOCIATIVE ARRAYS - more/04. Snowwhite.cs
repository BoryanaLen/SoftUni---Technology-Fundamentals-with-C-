using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            // string = name:color

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }

                List<string> inputInfo = input.Split(" <:> ").ToList();

                string name = inputInfo[0];
                string color = inputInfo[1];
                int physics = int.Parse(inputInfo[2]);
                string dwarfsKey = name + ':' + color;

                if (dwarfs.ContainsKey(dwarfsKey))
                {
                    if (dwarfs[dwarfsKey] < physics)
                    {
                        dwarfs[dwarfsKey] = physics;
                    }
                }
                else
                {
                    dwarfs.Add(dwarfsKey, physics);
                }
            }

            dwarfs = dwarfs.OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfs.Where(y => y.Key.Split(':')[1] == x.Key.Split(':')[1]).Count())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dwarfs)
            {
                string currentColor = item.Key.Split(':')[1];
                string currentName = item.Key.Split(':')[0];

                Console.WriteLine($"({currentColor}) {currentName} <-> {item.Value}");
            }

        }
    }
}
