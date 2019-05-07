using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            List<int> qualityList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> priceList = new List<int>();

            foreach(int num in qualityList)
            {
                priceList.Add(num * 3);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Hit it again, Gabsy!")
                {
                    Console.WriteLine(string.Join(' ', qualityList));
                    Console.WriteLine($"Gabsy has {budget:F2}lv.");
                    break;
                }

                int hitPower = int.Parse(input);

                for(int i = 0; i < qualityList.Count; i++)
                {
                    qualityList[i] -= hitPower;

                    if(qualityList[i] <= 0)
                    {
                        if(budget >= priceList[i])
                        {
                            budget -= priceList[i];
                            qualityList[i] = priceList[i] / 3;
                        }
                        else
                        {
                            qualityList.RemoveAt(i);
                            priceList.RemoveAt(i);
                            i -= 1;
                        }
                    }
                }
            }
        }
    }
}
