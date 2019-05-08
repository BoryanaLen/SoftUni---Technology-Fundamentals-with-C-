using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            //usetName, points
            Dictionary<string, int> submisions = new Dictionary<string, int>();
            // language, countSubmisions

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "exam finished")
                {
                    break;
                }

                List<string> inputInfo = input.Split('-').ToList();

                string username = inputInfo[0];

                if(inputInfo[1] != "banned")
                {
                    string language = inputInfo[1];
                    int points = int.Parse(inputInfo[2]);

                    if (users.ContainsKey(username))
                    {
                        if(users[username] < points)
                        {
                            users[username] = points;
                        }
                    }
                    else
                    {
                        users.Add(username, points);
                    }

                    if (submisions.ContainsKey(language))
                    {
                        submisions[language]++;
                    }
                    else
                    {
                        submisions.Add(language, 1);
                    }
                }
                else
                {
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                }
            }

            users = users.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Results:");

            foreach (var user in users)
            { 
               Console.WriteLine($"{user.Key} | {user.Value}");
            }

            submisions = submisions.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Submissions:");

            foreach(var item in submisions)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
