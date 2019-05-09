using System;

namespace _03._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                string inputSubstKey = "";

                foreach(char ch in input)
                {
                   int letter = ch - 3;
                   inputSubstKey += (char)letter;
                }

                int startPositionName;

                for (int i = 0; i < inputSubstKey.Length; i++)
                {
                    if(inputSubstKey[i] == '@')
                    {
                        startPositionName = i + 1;
                    }
                }


            }
        }
    }
}
