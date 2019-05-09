using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int sum = 0;

            int min = Math.Min(firstChar, secondChar);
            int max = Math.Max(firstChar, secondChar);

            foreach (char ch in text)
            {
                if (ch > min && ch < max)
                {
                    sum += ch;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
