using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static string GetMax(string type, string valueOne, string valueTwo)
        {
            string result = string.Empty;

            switch (type)
            {
                case "int":
                    int max = Math.Max(int.Parse(valueOne), int.Parse(valueTwo));
                    result += max;
                    break;
                case "char":
                    char[] chars = { char.Parse(valueOne), char.Parse(valueTwo) };
                    Array.Sort(chars);
                    char maxChar = chars[1];
                    result += maxChar;
                    break;
                case "string":
                    string [] strings = {valueOne, valueTwo};
                    Array.Sort(strings);
                    string maxString = strings[1];
                    result += maxString;
                    break;
            }


            return result;
        }


        static void Main(string[] args)
        {
            string typeInput = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            Console.WriteLine($"{GetMax(typeInput, value1, value2)}");
        }
    }
}
