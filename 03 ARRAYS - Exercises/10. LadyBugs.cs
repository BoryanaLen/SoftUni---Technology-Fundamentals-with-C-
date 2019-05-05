using System;
using System.Linq;
using System.Numerics;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] laladybugsArray = new int[size];

            int[] positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int a = 0; a < laladybugsArray.Length; a++)
            {
                laladybugsArray[a] = 0;
            }


            for (int i=0; i<positions.Length; i++)
            {
                if(positions[i]>=0 && positions[i] < laladybugsArray.Length)
                {
                    laladybugsArray[positions[i]] = 1;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                int startPosition = int.Parse(command.Split(' ')[0]);
                string direction = command.Split(' ')[1];
                int length = int.Parse(command.Split(' ')[2]);

                if (direction == "left")
                {
                    length *= -1;
                }

                if((startPosition < 0 || startPosition >= laladybugsArray.Length) || laladybugsArray[startPosition] == 0)
                {
                    continue;
                }

                laladybugsArray[(int)startPosition] = 0;

                while (true)
                {
                    startPosition += length;

                    if ((startPosition < 0 || startPosition >= laladybugsArray.Length))
                    {
                        break;
                    }

                    if (laladybugsArray[startPosition] == 0)
                    {
                        laladybugsArray[startPosition] = 1;
                        break;
                    }
                }             
            }


            for (int j = 0; j < laladybugsArray.Length; j++)
            {
                Console.Write($"{laladybugsArray[j]} ");
            }               
        }
    }
}



