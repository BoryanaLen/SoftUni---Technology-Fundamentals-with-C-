using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static string PrintSymbolsBetweenChars(char a, char b)
        {
            char start;
            char end;

            if (a > b)
            {
                start = b;
                end = a;
            }
            else
            {
                start = a;
                end = b;
            }

            string result = string.Empty;

            for(int i = start+1; i<end; i++)
            {
                result += (char)i;
                result += ' ';
            }

            return result;
        }

        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            Console.WriteLine(PrintSymbolsBetweenChars(start, end));
        }
    }
}
