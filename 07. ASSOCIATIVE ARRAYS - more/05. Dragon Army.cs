using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<double>>> types = new Dictionary<string, Dictionary<string, List<double>>>();

            for (int i = 0; i < number; i++)
            {
                List<string> inputInfo = Console.ReadLine().Split().ToList();
                //{type} {name} {damage} {health} {armor}

                string type = inputInfo[0];
                string name = inputInfo[1];
                double damage = 45;
                double health = 250;
                double armor = 10;

                if(inputInfo[2] != "null")
                {
                    damage = double.Parse(inputInfo[2]);
                }

                if(inputInfo[3] != "null")
                {
                    health = double.Parse(inputInfo[3]);
                }

                if (inputInfo[4] != "null")
                {
                    armor = double.Parse(inputInfo[4]);
                }

                List<double> currentStats = new List<double>() { damage, health, armor };

                if (types.ContainsKey(type))
                {
                    if (types[type].ContainsKey(name))
                    {
                        types[type][name] = currentStats;
                    }
                    else
                    {
                        types[type].Add(name, currentStats);
                    }
                }
                else
                {
                    Dictionary<string, List<double>> current = new Dictionary<string, List<double>>();
                    current.Add(name, currentStats);
                    types.Add(type, current);
                }
            }

            foreach(var kvp in types)
            {
                double averageDamage = kvp.Value.Select(x => x.Value[0]).Sum() / kvp.Value.Count;
                double averageHealth = kvp.Value.Select(x => x.Value[1]).Sum() / kvp.Value.Count;
                double averageArmor = kvp.Value.Select(x => x.Value[2]).Sum() / kvp.Value.Count;

                Console.WriteLine($"{kvp.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

                foreach (var element in kvp.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{element.Key} -> damage: {element.Value[0]}, health: {element.Value[1]}, armor: {element.Value[2]}");
                }
            }
        }
    }
}
