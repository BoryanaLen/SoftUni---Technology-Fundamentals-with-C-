using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Regex___06._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] separators = new char[] { ' ', '/', '\\', '(', ')' };

            List<string> words = text.Split(separators).ToList();

            string pattern = @"^[A-Za-z][A-Za-z0-9_]+";

            List<string> validUserNames = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if(Regex.IsMatch(words[i], pattern))
                {
                    string userName = Regex.Match(words[i], pattern).Value;

                    if(userName.Length>=3&& userName.Length <= 25)
                    {
                        validUserNames.Add(userName);
                    }
                }
            }

            int maxSum = 0;
            string nameOne = string.Empty;
            string nameTwo = string.Empty;

            for (int a = 0; a < validUserNames.Count-1; a++)
            {
                int currentSum = validUserNames[a].Length + validUserNames[a + 1].Length;

                if (currentSum > maxSum)
                {
                    nameOne = validUserNames[a];
                    nameTwo = validUserNames[a + 1];
                    maxSum = currentSum;
                }
            }

            Console.WriteLine(nameOne);
            Console.WriteLine(nameTwo);
        }
    }
}
