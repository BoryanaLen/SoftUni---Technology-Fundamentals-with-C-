using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "no more time")
                {
                    break;
                }

                List<string> inputInfo = input.Split(" -> ").ToList();

                string username = inputInfo[0];
                string contest = inputInfo[1];
                int points = int.Parse(inputInfo[2]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest].ContainsKey(username))
                    {
                        if(contests[contest][username] < points)
                        {
                            contests[contest][username] = points;
                        }
                    }
                    else
                    {
                        contests[contest].Add(username, points);
                    }
                }
                else
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(username, points);
                    contests.Add(contest, current);
                }

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
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(contest, points);
                    users.Add(username, current);
                }
            }

            foreach(var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                var sortedPoints = contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

                int row = 1;

                foreach(var element in sortedPoints)
                {
                    Console.WriteLine($"{row}. {element.Key} <::> {element.Value}");
                    row++;
                }
            }

            Console.WriteLine("Individual standings:");

            var sortedUsers = users.ToDictionary(x => x.Key, x => x.Value.Sum(a => a.Value));
            sortedUsers = sortedUsers.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            int rowTwo = 1;

            foreach(var user in sortedUsers)
            {
                Console.WriteLine($"{rowTwo}. {user.Key} -> {user.Value}");
                rowTwo++;
            }
        }
    }
}
