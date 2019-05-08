using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"fragments", 0 },
                {"motes", 0 }
            };
 
            Dictionary<string, int> junks = new Dictionary<string, int>();

            while (true)
            {
                List<string> inputInfo = Console.ReadLine().Split().ToList();

                List<int> numbers = new List<int>();
                List<string> names = new List<string>();

                for(int a = 0; a< inputInfo.Count; a++)
                {
                    if (a % 2 == 0)
                    {
                        numbers.Add(int.Parse(inputInfo[a]));
                    }
                    else
                    {
                        names.Add(inputInfo[a].ToLower());
                    }
                }

                int countForBreak = 0;

                for (int i = 0; i < names.Count; i++)
                {
                    int count = 0;

                    if(names[i] == "shards")
                    {
                        items["shards"] += numbers[i];

                        count++;

                        if (items["shards"] >= 250)
                        {
                            Console.WriteLine($"Shadowmourne obtained!");
                            items["shards"] -= 250;
                            countForBreak++;
                            break;
                        }
                    }
                    else if(names[i] == "fragments")
                    {
                        items["fragments"] += numbers[i];

                        count++;

                        if (items["fragments"] >= 250)
                        {
                            Console.WriteLine($"Valanyr obtained!");
                            items["fragments"] -= 250;
                            countForBreak++;
                            break;
                        }
                    }
                    else if (names[i] == "motes")
                    {
                        items["motes"] += numbers[i];

                        count++;

                        if (items["motes"] >= 250)
                        {
                            Console.WriteLine($"Dragonwrath obtained!");
                            items["motes"] -= 250;
                            countForBreak++;
                            break;
                        }
                    }

                    if(count == 0)
                    {
                        if (junks.ContainsKey(names[i]))
                        {
                            junks[names[i]] += numbers[i];
                        }
                        else
                        {
                            junks.Add(names[i], numbers[i]);
                        } 
                    }
                }

                if (countForBreak > 0)
                {
                    break;
                }
            }

            items = items.OrderByDescending(x => x.Value).ThenBy(x => x.Key).
                ToDictionary(x => x.Key, x => x.Value);

            junks = junks.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach(var element in junks)
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }
    }
}
