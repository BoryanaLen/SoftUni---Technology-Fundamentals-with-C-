using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Regex___08._Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\<(?<mine>.{2})\>";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach(Match match in matches)
            {
                string mine = match.Groups["mine"].Value;

                int power = Math.Abs(mine[0] - mine[1]);

                int indexMine = input.IndexOf(match.Value);

                int startPosition = indexMine - power;

                if (startPosition < 0)
                {
                    startPosition = 0;
                }

                int endPosition = indexMine + power + 3;

                if (endPosition > input.Length - 1)
                {
                    endPosition = input.Length - 1;
                }

                int length = endPosition - startPosition + 1;

                input = input.Substring(0, startPosition) + new string('_', length) + input.Substring(endPosition + 1);
               
            }

            Console.WriteLine(input);
        }
    }
}
