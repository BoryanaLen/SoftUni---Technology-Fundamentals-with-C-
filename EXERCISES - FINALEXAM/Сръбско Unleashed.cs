using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Dictionary___10._Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> venues = new Dictionary<string, Dictionary<string, int>>();

            string pattern = @"^(?<singer>([A-Za-z]+\s){1,3})\@(?<venue>([A-Za-z]+\s){1,3})(?<price>[0-9]+)\s(?<count>[0-9]+)$";

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                if(Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    string singer = match.Groups["singer"].Value.TrimEnd();

                    string venue = match.Groups["venue"].Value.TrimEnd();

                    int price = int.Parse(match.Groups["price"].Value);

                    int count = int.Parse(match.Groups["count"].Value);

                    int totalMoney = price * count;

                    if (venues.ContainsKey(venue))
                    {
                        if (venues[venue].ContainsKey(singer))
                        {
                            venues[venue][singer] += totalMoney;
                        }
                        else
                        {
                            venues[venue].Add(singer, totalMoney);
                        }
                    }
                    else
                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();

                        current.Add(singer, totalMoney);

                        venues.Add(venue, current);
                    }
                }
            }

            foreach(var kvp in venues)
            {
                var orderedSingers = kvp.Value.OrderByDescending(x => x.Value);

                Console.WriteLine(kvp.Key);

                foreach(var element in orderedSingers)
                {
                    Console.WriteLine($"#  {element.Key} -> {element.Value}");
                }
            }
        }
    }
}
