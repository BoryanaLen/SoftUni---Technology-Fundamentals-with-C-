using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> totalPoints = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of contests")
                {
                    break;
                }

                List<string> inputInfo = input.Split(':').ToList();

                string contest = inputInfo[0];
                string password = inputInfo[1];

                contests.Add(contest, password);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                List<string> inputInfo = input.Split("=>").ToList();

                string contest = inputInfo[0];
                string password = inputInfo[1];
                string username = inputInfo[2];
                int points = int.Parse(inputInfo[3]);

                if (contests.ContainsKey(contest))
                {
                    if(contests[contest] == password)
                    {
                        if (users.ContainsKey(username))
                        {
                            if (users[username].ContainsKey(contest))
                            {
                                if (users[username][contest] < points)
                                {
                                    users[username][contest] = points;
                                }
                            }
                            else
                            {
                                users[username].Add(contest, points);
                            }
                        }
                        else
                        {
                            Dictionary<string, int> currentDictionary = new Dictionary<string, int>();
                            currentDictionary.Add(contest, points);
                            users.Add(username, currentDictionary);
                        }
                    }
                }
            }

            foreach(var user in users)
            {
                int sum = user.Value.Sum(x => x.Value);
                totalPoints.Add(user.Key, sum);
            }

            totalPoints = totalPoints.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            users = users.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Best candidate is {totalPoints.First().Key} with total {totalPoints.First().Value} points.");

            Console.WriteLine("Ranking: ");

            foreach(var item in users)
            {
                Console.WriteLine($"{item.Key}");

                Dictionary<string, int> current = new Dictionary<string, int>();
                current = item.Value;

                current = current.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach(var element in current)
                {
                    Console.WriteLine($"# {element.Key} -> {element.Value}");
                }
            }
        }
    }
}
