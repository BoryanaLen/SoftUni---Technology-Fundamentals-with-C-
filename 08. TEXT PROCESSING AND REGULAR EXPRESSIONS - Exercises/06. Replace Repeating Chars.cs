using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            char current = text[0];

            sb.Append(current);

            for (int i = 1; i < text.Length; i++)
            {
                if(text[i] == current)
                {
                    continue;
                }

                sb.Append(text[i]);

                current = text[i];
            }

            Console.WriteLine(sb);
        }
    }
}
