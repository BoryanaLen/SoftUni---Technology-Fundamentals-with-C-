using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Dictionary___11._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<double>>> types = new Dictionary<string, Dictionary<string, List<double>>>();

            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                string input = Console.ReadLine();

                List<string> inputInfo = input.Split().ToList();

                string type = inputInfo[0];

                string name = inputInfo[1];

                double damage = 0;

                double health = 0;

                double armor = 0;

                if(inputInfo[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = double.Parse(inputInfo[2]);
                }

                if (inputInfo[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = double.Parse(inputInfo[3]);
                }

                if (inputInfo[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = double.Parse(inputInfo[4]);
                }

                List<double> currentStatus = new List<double>() { damage, health, armor };

                if (types.ContainsKey(type))
                {
                    if (types[type].ContainsKey(name))
                    {
                        types[type][name] = currentStatus;
                    }
                    else
                    {
                        types[type].Add(name, currentStatus);
                    }
                }
                else
                {
                    Dictionary<string, List<double>> current = new Dictionary<string, List<double>>();

                    current.Add(name, currentStatus);

                    types.Add(type, current);
                }
            }

            foreach(var kvp in types)
            {
                var names = kvp.Value.OrderBy(x => x.Key);

                double averageDamage = names.Average(x => x.Value[0]);

                double averageHealth = names.Average(x => x.Value[1]);

                double averageArmor = names.Average(x => x.Value[2]);

                Console.WriteLine($"{kvp.Key}::({averageDamage:f2}/{averageHealth:F2}/{averageArmor:F2})");

                foreach(var item in names)
                {
                    Console.WriteLine($"-{item.Key} -> damage: {item.Value[0]}, health: {item.Value[1]}, armor: {item.Value[2]}");
                }
            }
        }
    }
}
