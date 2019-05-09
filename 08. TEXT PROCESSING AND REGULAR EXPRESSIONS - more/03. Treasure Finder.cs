using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                int position = 0;
                string input = Console.ReadLine();

                if(input == "find")
                {
                    break;
                }

                StringBuilder sb = new StringBuilder();

                foreach(char ch in input)
                {
                    if (position >= numbers.Count)
                    {
                        position = 0;
                    }

                    int number = numbers[position];
                    sb.Append((char)(ch - number));
                    position++;
                }

                string text = sb.ToString();
                string pattern = @"\&(?<type>[A-Za-z]+)\&(.+?)?\<(?<coordinates>[A-Za-z0-9]+)\>";

                if (Regex.IsMatch(text, pattern))
                {
                    string type = Regex.Match(text, pattern).Groups["type"].Value;
                    string coordinates = Regex.Match(text, pattern).Groups["coordinates"].Value;

                    Console.WriteLine($"Found {type} at { coordinates}");
                }
            }
        }
    }
}
