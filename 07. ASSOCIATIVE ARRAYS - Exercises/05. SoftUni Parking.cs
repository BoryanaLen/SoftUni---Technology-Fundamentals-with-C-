using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                List<string> commandInfo = Console.ReadLine().Split().ToList();

                string command = commandInfo[0];
                string userName = commandInfo[1];

                if (command == "register")
                {
                    string licensePlateNumber = commandInfo[2];

                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        users.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                }
                else if(command == "unregister")
                {
                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        users.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }

            foreach(var element in users)
            {
                Console.WriteLine($"{element.Key} => {element.Value}");
            }
        }
    }
}
