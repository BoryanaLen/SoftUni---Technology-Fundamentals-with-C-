using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {".-", "A"}, {"-...", "B"}, {"-.-.", "C"}, {"-..", "D"},
                {".", "E"}, {"..-.", "F"}, {"--.", "G"}, {"....", "H"}, {"..", "I"}, {".---", "J"}, {"-.-", "K"},
                {".-..", "L"}, {"--", "M"}, {"-.", "N"}, {"---", "O"}, {".--.", "P"}, {"--.-", "Q"}, {".-.", "R"},
                {"...", "S"}, {"-", "T"}, {"..-", "U"}, {"...-", "V"}, {".--", "W"}, {"-..-", "X"}, {"-.--", "Y"},
                {"--..", "Z"}
            };

            List<string> morseCode = Console.ReadLine().Split(" | ").ToList();
            List<string> words = new List<string>();

            for (int i = 0; i < morseCode.Count; i++)
            {
                StringBuilder sb = new StringBuilder();

                List<string> wordInfo = morseCode[i].Split().ToList();

                foreach(string symbol in wordInfo)
                {
                    if (dictionary.ContainsKey(symbol))
                    {
                        sb.Append(dictionary[symbol]);
                    }
                }

                words.Add(sb.ToString().ToUpper());
            }

            Console.WriteLine(string.Join(' ', words));
        }
    }
}
