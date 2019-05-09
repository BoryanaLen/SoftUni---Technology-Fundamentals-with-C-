using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Regex___04_Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();

            StringBuilder sb = new StringBuilder();

            string patternOne = @"([1]{2,})";
            string patternZero = @"([0]{2,})";

            for (int i = 0; i < input.Count; i++)
            {
                string currentPart = input[i];

                int countOne = currentPart.Count(x => x == '1');
                int countZero = currentPart.Count(x => x == '0');

                int total = countOne * 5 + countZero * 3;

                MatchCollection matchesOne = Regex.Matches(currentPart, patternOne);

                int countMatchOne = matchesOne.Sum(x => x.Value.Length);

                MatchCollection matchesZero = Regex.Matches(currentPart, patternZero);

                int countMatchZero = matchesZero.Sum(x => x.Value.Length);

                total += (countMatchOne + countMatchZero);

                sb.Append((char)total);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
