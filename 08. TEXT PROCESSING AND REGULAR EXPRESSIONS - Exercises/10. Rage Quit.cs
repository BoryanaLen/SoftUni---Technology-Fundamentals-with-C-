using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _10._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToUpper();

            string pattern = @"([^\d]+)(\d+)";

            StringBuilder sb = new StringBuilder();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach(Match match in matches)
            {
                int count = int.Parse(match.Groups[2].Value);
                string wordToAdd = match.Groups[1].Value;

                for (int i = 0; i < count; i++)
                {
                    sb.Append(wordToAdd);
                }
            }

            string symbols = sb.ToString();
            int countSymbols = symbols.Distinct().Count();

            Console.WriteLine($"Unique symbols used: {countSymbols}");
            Console.WriteLine(symbols);
        }
    }
}
