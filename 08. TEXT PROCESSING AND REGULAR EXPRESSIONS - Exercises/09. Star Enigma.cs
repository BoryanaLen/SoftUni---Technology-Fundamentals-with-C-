using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberNessages = int.Parse(Console.ReadLine());

            int attackedCount = 0;
            int destroyedCount = 0;
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            List<string> messages = new List<string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numberNessages; i++)
            {
                string message = Console.ReadLine();

                string regex = @"[starSTAR]";

                MatchCollection matches = Regex.Matches(message, regex);

                int countLetters = matches.Count;

                for (int j = 0; j < message.Length; j++)
                {
                    sb.Append((char)(message[j] - countLetters));
                }

                string decryptedWord = sb.ToString();

                messages.Add(decryptedWord);

                sb.Clear();
            }

            string pattern = @"([^@:!\->]*)@([A-Za-z]+)([^@:!\->]*):([0-9]+)([^@:!\->]*)!([AD])!([^@:!\->]*)->([0-9]+)([^@:!\->]*)";

            foreach (var item in messages)
            {
                if (Regex.IsMatch(item, pattern))
                {
                    var name = Regex.Match(item, pattern).Groups[2].Value;
                    var type = Regex.Match(item, pattern).Groups[6].Value;

                    if (type == "A")
                    {
                        attackedCount++;
                        attackedPlanets.Add(name);
                    }
                    else if (type == "D")
                    {
                        destroyedCount++;
                        destroyedPlanets.Add(name);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedCount}");

            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            foreach (string name in attackedPlanets)
            {
                Console.WriteLine($"-> {name}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedCount}");

            foreach (string name in destroyedPlanets)
            {
                Console.WriteLine($"-> {name}");
            }
        }
    }
}
