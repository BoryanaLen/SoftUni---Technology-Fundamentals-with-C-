using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static bool IsNumberPalindrome(string input)
        {
            bool isPalindrome = false;
            int count = 0;

            for(int i = 0; i<input.Length/2; i++)
            {
                if (input[i] == input[input.Length - i -1])
                {
                    count++;
                }
            }

            if (count == input.Length / 2)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();

                if(text == "END")
                {
                    break;
                }

                Console.WriteLine($"{IsNumberPalindrome(text).ToString().ToLower()}");
            }
        }
    }
}
