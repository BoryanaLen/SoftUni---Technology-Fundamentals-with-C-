using System;
using System.Collections.Generic;
using System.Linq;


namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Lumpawaroo")
                {
                    break;
                }

                if(input.IndexOf('|') >= 0)
                {
                    List<string> inputInfo = input.Split(" | ").ToList();

                    string forceSide = inputInfo[0];
                    string forceUser = inputInfo[1];

                    int count = 0;

                    foreach(var item in sides)
                    {
                        if(item.Value.IndexOf(forceUser) >= 0)
                        {
                            count++;
                        }
                    }

                    if(count == 0)
                    {
                        if (sides.ContainsKey(forceSide))
                        {
                            sides[forceSide].Add(forceUser);
                        }
                        else
                        {
                            sides.Add(forceSide, new List<string>() { forceUser });
                        }
                    }                    
                }
                else
                {
                    List<string> inputInfo = input.Split(" -> ").ToList();

                    string forceSide = inputInfo[1];
                    string forceUser = inputInfo[0];

                    int count = 0;
                    string key = "";

                    foreach (var item in sides)
                    {
                        if (item.Value.IndexOf(forceUser) >= 0)
                        {
                            count++;
                            key = item.Key;
                        }
                    }

                    if(count > 0)
                    {
                        sides[key].Remove(forceUser);
                    }

                    if (sides.ContainsKey(forceSide))
                    {
                        sides[forceSide].Add(forceUser);
                    }
                    else
                    {
                        sides.Add(forceSide, new List<string>() { forceUser });
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

           sides = sides.OrderByDescending(x => x.Value.Count)
                .ThenBy(a => a.Key).ToDictionary(x => x.Key, x => x.Value);

           sides = sides.Where(x => x.Value.Count > 0).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sides)
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                item.Value.Sort();

                foreach(string user in item.Value)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
