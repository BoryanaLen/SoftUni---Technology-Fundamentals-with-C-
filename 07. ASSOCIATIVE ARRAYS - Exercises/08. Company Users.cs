using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                List<string> inputInfo = input.Split(" -> ").ToList();

                string companyName = inputInfo[0];
                string employeeId = inputInfo[1];

                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                }
                else
                {
                    companies.Add(companyName, new List<string>() { employeeId });
                }
            }

            foreach(var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                foreach(string id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
