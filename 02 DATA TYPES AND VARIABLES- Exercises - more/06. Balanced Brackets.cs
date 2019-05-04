using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            char lastBracket = ' ';
            bool isBalanced = true;
            int count = 0;

            for (int i = 0; i < numberLines; i++)
            {
               string input = Console.ReadLine();

               if(char.TryParse(input, out char charResult))
               {
                    if (charResult == '(')
                    {
                        if (lastBracket == charResult)
                        {
                            isBalanced = false;
                        }
                        else
                        {
                            lastBracket = charResult;
                            count++;
                        }
                    }
                    else if (charResult == ')')
                    {
                        if (lastBracket == charResult)
                        {
                            isBalanced = false;
                        }
                        else 
                        {
                            lastBracket = charResult;
                            count++;
                        }
                    }
                }
            }
            if (numberLines == 1)
            {
                Console.WriteLine("UNBALANCED");
            }
            else if (isBalanced==true && (count%2==0))
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
