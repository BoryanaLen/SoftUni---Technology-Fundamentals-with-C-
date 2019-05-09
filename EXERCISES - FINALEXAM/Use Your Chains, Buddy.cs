using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Regex___08._Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> messages = new List<string>();

            string pattern = @"(\<[p]\>)(?<text>.+?)\<\/[p]\>";

            string patternSpaces = @"[^a-z0-9]+";

            StringBuilder sb = new StringBuilder();

            MatchCollection matches = Regex.Matches(input, pattern);

            for (int i = 0; i < matches.Count; i++)
            {
                string text = matches[i].Groups["text"].Value;

                string textWithoutSpaces = Regex.Replace(text, patternSpaces, " ");

                for (int a = 0; a < textWithoutSpaces.Length; a++)
                {
                    char currentChar = textWithoutSpaces[a];

                    if (currentChar >= 'a' && currentChar <= 'm')
                    {
                        currentChar = (char)(currentChar + 13);
                    }
                    else if (currentChar >= 'n' && currentChar <= 'z')
                    {
                        currentChar = (char)(currentChar - 13);
                    }

                    sb.Append(currentChar);
                }
            }

            string newText = sb.ToString();

            string finalText = Regex.Replace(newText, @"\s+", " ");

            Console.WriteLine(finalText);
        }
    }
}
