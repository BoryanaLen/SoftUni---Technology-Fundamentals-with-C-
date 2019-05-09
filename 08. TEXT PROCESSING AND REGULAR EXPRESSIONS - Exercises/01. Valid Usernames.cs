using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();

            string regex = @"^[a-zA-Z0-9_-]{3,16}$";

            for (int i = 0; i < names.Count; i++)
            {
                string name = names[i];

                if(Regex.IsMatch(name, regex))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
