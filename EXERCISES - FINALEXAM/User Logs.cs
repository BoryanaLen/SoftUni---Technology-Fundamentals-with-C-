using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Dictionary___06._User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                List<string> inputInfo = input.Split().ToList();

                string ip = inputInfo[0].Split('=').ToList()[1];
                string message = inputInfo[1].Split('=').ToList()[1];
                string user = inputInfo[2].Split('=').ToList()[1];

                if (users.ContainsKey(user))
                {
                    if (users[user].ContainsKey(ip))
                    {
                        users[user][ip]++;
                    }
                    else
                    {
                        users[user].Add(ip, 1);
                    }
                }
                else
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(ip, 1);
                    users.Add(user, current);
                }
            }

            var orderedUsers = users.OrderBy(x => x.Key);

            foreach(var kvp in orderedUsers)
            {
                var currenrIPs = kvp.Value;

                Console.WriteLine($"{kvp.Key}: ");

                List<string> ipList = new List<string>();

                foreach(var item in currenrIPs)
                {
                    string text = $"{item.Key} => {item.Value}";

                    ipList.Add(text);
                }

                Console.WriteLine($"{string.Join(", ", ipList)}.");
            }
        }
    }
}
