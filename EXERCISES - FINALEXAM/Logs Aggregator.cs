using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Dictionary___08._Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            Dictionary<string, int> durations = new Dictionary<string, int>();

            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                string input = Console.ReadLine();

                List<string> inputInfo = input.Split().ToList();

                string ip = inputInfo[0];

                string name = inputInfo[1];

                int duration = int.Parse(inputInfo[2]);

                if (users.ContainsKey(name))
                {
                    if (!users[name].Contains(ip))
                    {
                        users[name].Add(ip);
                    }
                }
                else
                {
                    users.Add(name, new List<string>() { ip });
                }

                if (durations.ContainsKey(name))
                {
                    durations[name] += duration;
                }
                else
                {
                    durations.Add(name, duration);
                }
            }

            var orderedUsers = users.OrderBy(x => x.Key);

            foreach(var kvp in orderedUsers)
            {
                var currentIPList = kvp.Value;
                currentIPList.Sort();

                Console.WriteLine($"{kvp.Key}: {durations[kvp.Key]} [{string.Join(", ", currentIPList)}]");
            }
        }
    }
}
