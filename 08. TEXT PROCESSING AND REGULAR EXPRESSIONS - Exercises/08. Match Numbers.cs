using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))[\-]{0,1}[0-9]+([\.][0-9]+){0,1}($|(?=\s))";

            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, regex);

            List<string> numbers = matches.Cast<Match>()
                .Select(m => m.Value)
                .ToList();

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
