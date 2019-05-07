using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listArrays = Console.ReadLine().Split('|').ToList();

            int countArrays = listArrays.Count;
            string result = string.Empty;

            for(int i = countArrays -1 ; i >=0; i--)
            {
                List<int> numbers = listArrays[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                foreach(int num in numbers)
                {
                    result += num;
                    result += ' ';
                }
            }

            Console.WriteLine(result.Trim());
        }
    }
}
