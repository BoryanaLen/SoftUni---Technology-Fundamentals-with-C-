using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> textInfo = Console.ReadLine().Split('>').ToList();

            StringBuilder sb = new StringBuilder();
            sb.Append(textInfo[0]);
            int additionalStrength = 0;

            for (int i = 1; i < textInfo.Count; i++)
            {
                string word = textInfo[i];

                int strength = word[0] - '0' + additionalStrength;

                if (strength < word.Length)
                {
                    word = word.Substring(strength);
                    sb.Append('>' + word);
                    additionalStrength = 0;
                }
                else if(strength == word.Length)
                {
                    word = "";
                    sb.Append('>' + word);
                    additionalStrength = 0;
                }
                else
                {
                    additionalStrength = strength - word.Length;
                    sb.Append('>');
                }
            }

            Console.WriteLine(sb);
        }
    }
}
