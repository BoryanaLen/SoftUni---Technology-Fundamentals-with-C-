using System;

namespace _07._Repeat_String
{
    class Program
    {
        static string RepeatedString(string stringForRepeat, int numberRepeats)
        {
            string result = string.Empty;

            for(int i =0; i<numberRepeats; i++)
            {
                result += stringForRepeat;
            }

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"{RepeatedString(Console.ReadLine(), int.Parse(Console.ReadLine()))}");
        }
    }
}
