using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static string PrintMiddleCharacter(string text)
        {
            string result = string.Empty;

            if (text.Length % 2 == 0)
            {
                result += text[text.Length / 2 - 1];
                result += text[text.Length / 2];
            }
            else
            {
                result+= text[text.Length / 2];
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PrintMiddleCharacter(Console.ReadLine()));
        }
    }
}
