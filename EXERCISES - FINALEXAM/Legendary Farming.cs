using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Dictionary___09._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
                {"shards",0 },
                {"fragments", 0 },
                {"motes", 0 }
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            while(true)
            {
                string input = Console.ReadLine();

                List<string> inputInfo = input.Split().ToList();

                int count = 0;

                for (int i = 0; i < inputInfo.Count - 1; i += 2)
                {
                    int quantity = int.Parse(inputInfo[i]);

                    string material = inputInfo[i + 1].ToLower();

                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;

                        if (materials[material] >= 250)
                        {
                            if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }

                            materials[material] -= 250;

                            count++;

                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk.Add(material, quantity);
                        }
                    }
                }

                if (count > 0)
                {
                    break;
                }
            }

            var orderedMaterials = materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var kvp in orderedMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            var orderedJunk = junk.OrderBy(x => x.Key);

            foreach (var kvp in orderedJunk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
