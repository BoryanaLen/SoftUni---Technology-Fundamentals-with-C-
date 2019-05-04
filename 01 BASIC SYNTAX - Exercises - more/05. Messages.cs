using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string input;
            int number;
            string alpha = "";
            int ofset = 0;
            int numberChar;
            string sms = "";

            for(char i='a'; i<='z'; i++)
            {
                alpha += i;
            }

            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine();
                number = (int.Parse(input)) % 10;

                if (number == 0)
                {
                    sms += " ";
                    continue;
                }

                if (number == 8 || number==9)
                {
                    ofset = (number - 2) * 3 + 1;
                }
                else
                {
                    ofset = (number - 2) * 3;
                }

                numberChar = ofset + input.Length - 1;

                sms += alpha[numberChar];
            }

            Console.WriteLine(sms);
        }
    }
}
