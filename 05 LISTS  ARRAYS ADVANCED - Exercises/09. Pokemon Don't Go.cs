using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int SumRemovedElements = 0;

            while(sequence.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                int valueForIncrease = 0;

                if (index < 0 )
                {
                    SumRemovedElements += sequence[0];
                    valueForIncrease = sequence[0];
                    sequence[0] = sequence[sequence.Count - 1];
                }
                else if (index > (sequence.Count - 1))
                {
                    SumRemovedElements += sequence[sequence.Count - 1];
                    valueForIncrease = sequence[sequence.Count - 1];
                    sequence.RemoveAt(sequence.Count - 1);
                    sequence.Add(sequence[0]);
                }
                else
                {
                    valueForIncrease = sequence[index];
                    sequence.RemoveAt(index);
                    SumRemovedElements += valueForIncrease;
                }

                for(int i = 0; i< sequence.Count; i++)
                {
                    if(sequence[i] <= valueForIncrease)
                    {
                        sequence[i] += valueForIncrease;
                    }
                    else
                    {
                        sequence[i] -= valueForIncrease;
                    }
                }
            }

            Console.WriteLine(SumRemovedElements);
        }
    }
}
