using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string patternSynbols = @"[^\d\.\+\-\*\/]+";
            string patternNumbers = @"[-+]{0,1}[0-9]+[.]{0,1}[0-9]*";
            names.Sort();

            for (int i = 0; i < names.Count; i++)
            {
                string name = names[i].Trim();
                int sumAsciCodes = 0;
                double sumNumbers = 0;

                if(Regex.IsMatch(name, patternSynbols))
                {
                    foreach(Match match in Regex.Matches(name, patternSynbols))
                    {
                        foreach(char ch in match.Value)
                        {
                            sumAsciCodes += ch;
                        }                     
                    }
                }

                if (Regex.IsMatch(name, patternNumbers))
                {
                    foreach (Match match in Regex.Matches(name, patternNumbers))
                    {
                        double number = double.Parse(match.Value);
                        sumNumbers += number;
                    }
                }

                foreach(char ch in name)
                {
                    if(ch == '*')
                    {
                        sumNumbers *= 2;
                    }

                    if(ch == '/')
                    {
                        sumNumbers /= 2;
                    }
                }

                Console.WriteLine($"{name} - {sumAsciCodes} health, {sumNumbers:F2} damage");
            }
        }
    }
}
