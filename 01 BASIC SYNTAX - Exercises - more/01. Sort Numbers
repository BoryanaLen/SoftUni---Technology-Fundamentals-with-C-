using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] array = new int[] { a, b, c };

            int min = int.MaxValue;
 
            for(int i=0; i<2; i++)
            {
                for(int j = i+1; j<3; j++)
                {
                    if (array[i] < array[j])
                    {
                        min = array[i];

                        array[i] = array[j];
                        array[j] = min;
                    }
                }
            }

            foreach(int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
