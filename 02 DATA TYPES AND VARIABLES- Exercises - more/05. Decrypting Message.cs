using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberLines = int.Parse(Console.ReadLine());
            string result = "";

            for(int i=0; i<numberLines; i++)
            {
                char ch = char.Parse(Console.ReadLine());

                int letter = ch + key;

                result += (char)letter;
            }

            Console.Write(result);
        }
    }
}
