using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            string patternOne = @"\@(?<name>[A-Za-z]+)\|(.+?)?\#(?<age>[0-9]+)\*";
            string patternTwo = @"\#(?<age>[0-9]+)\*(.+?)?\@(?<name>[A-Za-z]+)\|";

            for (int i = 0; i < numberLines; i++)
            {
                string text = Console.ReadLine();

                if (Regex.IsMatch(text, patternOne))
                {
                    string name = Regex.Match(text, patternOne).Groups["name"].Value;
                    int age = int.Parse(Regex.Match(text, patternOne).Groups["age"].Value);

                    Console.WriteLine($"{name} is {age} years old.");
                }
                else if (Regex.IsMatch(text, patternTwo))
                {
                    string name = Regex.Match(text, patternTwo).Groups["name"].Value;
                    int age = int.Parse(Regex.Match(text, patternTwo).Groups["age"].Value);

                    Console.WriteLine($"{name} is {age} years old.");
                }
            }
        }
    }
}
