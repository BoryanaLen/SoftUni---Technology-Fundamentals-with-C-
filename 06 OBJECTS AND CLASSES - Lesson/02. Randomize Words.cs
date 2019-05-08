using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();

            while(words.Count > 0)
            {
                Random random = new Random ();

                int position = random.Next(0, words.Count);

                Console.WriteLine(words[position]);

                words.RemoveAt(position);
            }
        }
    }
}
