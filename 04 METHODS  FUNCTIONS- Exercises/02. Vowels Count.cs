using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static int GetCountVowel(string text)
        {
            int count = 0;
            string vowel = "aeiou";
            string textToLower = text.ToLower();

            foreach (char ch in textToLower)
            {
                if (vowel.IndexOf(ch)>=0)
                {
                    count++;
                }
            }

            return count;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"{GetCountVowel(Console.ReadLine())}");
        }
    }
}
