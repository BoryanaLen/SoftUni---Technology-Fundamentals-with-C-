using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach(char ch in text)
            {
                if(ch!=' ')
                {
                    if (chars.ContainsKey(ch))
                    {
                        chars[ch]++;
                    }
                    else
                    {
                        chars.Add(ch, 1);
                    }
                }
            }

            foreach(var element in chars)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
