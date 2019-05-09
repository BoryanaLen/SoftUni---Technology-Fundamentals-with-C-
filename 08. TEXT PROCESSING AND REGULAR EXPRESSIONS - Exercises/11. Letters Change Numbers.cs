using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _11._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"([A-Za-z])([0-9]+)([A-Za-z])";

            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            MatchCollection matches = Regex.Matches(text, pattern);

            double totalSum = 0;

            foreach(Match match in matches)
            {
                string currentWord = match.Value;
                char firstLetter = currentWord[0];
                char lastLetter = currentWord[currentWord.Length-1];
                double number = double.Parse(match.Groups[2].Value);

                int indexFirstLetter = alpha.IndexOf(Char.ToUpper(firstLetter)) + 1;
                int indexLastLetter = alpha.IndexOf(Char.ToUpper(lastLetter)) + 1;

                if (char.IsUpper(firstLetter))
                {
                    number /= indexFirstLetter;
                }
                else
                {
                    number *= indexFirstLetter;
                }

                if(char.IsUpper(lastLetter))
                {
                    number -= indexLastLetter;
                }
                else
                {
                    number += indexLastLetter;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
