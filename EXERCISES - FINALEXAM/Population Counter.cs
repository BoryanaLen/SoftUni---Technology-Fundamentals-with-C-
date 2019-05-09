using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "report")
                {
                    break;
                }

                List<string> inputInfo = input.Split('|').ToList();

                string city = inputInfo[0];
                string country = inputInfo[1];
                long population = long.Parse(inputInfo[2]);

                if (countries.ContainsKey(country))
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);
                    }
                }
                else
                {
                    Dictionary<string, long> current = new Dictionary<string, long>();

                    current.Add(city, population);

                    countries.Add(country, current);
                }
            }

            var orderedCountries = countries.OrderByDescending(x => x.Value.Sum(a => a.Value));

            foreach(var kvp in orderedCountries)
            {
                var currentCities = kvp.Value.OrderByDescending(x => x.Value);

                long totalPopulation = currentCities.Sum(a => a.Value);

                Console.WriteLine($"{kvp.Key} (total population: {totalPopulation})");

                foreach(var element in currentCities)
                {
                    Console.WriteLine($"=>{element.Key}: {element.Value}");
                }
            }
        }
    }
}
