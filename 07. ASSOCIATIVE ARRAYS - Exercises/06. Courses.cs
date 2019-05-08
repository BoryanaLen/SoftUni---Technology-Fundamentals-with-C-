using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                List<string> inputInfo = input.Split(" : ").ToList();

                string courseName = inputInfo[0];
                string registeredStudents = inputInfo[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(registeredStudents);
                }
                else
                {
                    courses.Add(courseName, new List<string>() { registeredStudents });
                }
            }

            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach(var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                item.Value.Sort();

                foreach(string name in item.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
