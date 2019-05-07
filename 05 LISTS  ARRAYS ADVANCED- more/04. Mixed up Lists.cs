using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int maxNumber;
            int minNumber;

            if(listOne.Count > listTwo.Count)
            {
                maxNumber = Math.Max(listOne[listOne.Count - 1], listOne[listOne.Count - 2]);
                minNumber = Math.Min(listOne[listOne.Count - 1], listOne[listOne.Count - 2]);
            }
            else
            {
                maxNumber = Math.Max(listTwo[0], listTwo[1]);
                minNumber = Math.Min(listTwo[0], listTwo[1]);
            }

            foreach(int num in listOne)
            {
                if (num > minNumber && num < maxNumber)
                {
                    result.Add(num);
                }
            }

            foreach (int num in listTwo)
            {
                if (num > minNumber && num < maxNumber)
                {
                    result.Add(num);
                }
            }

            result.Sort();

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
