using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cardsFirstPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> cardsSecondPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                if(cardsSecondPlayer.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {cardsFirstPlayer.Sum()}");
                    break;
                }

                if (cardsFirstPlayer.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {cardsSecondPlayer.Sum()}");
                    break;
                }

                if (cardsFirstPlayer[0] > cardsSecondPlayer[0])
                {
                    cardsFirstPlayer.Add(cardsFirstPlayer[0]);
                    cardsFirstPlayer.Add(cardsSecondPlayer[0]);

                    cardsFirstPlayer.RemoveAt(0);
                    cardsSecondPlayer.RemoveAt(0);
                }
                else if (cardsFirstPlayer[0] < cardsSecondPlayer[0])
                {
                    cardsSecondPlayer.Add(cardsSecondPlayer[0]);
                    cardsSecondPlayer.Add(cardsFirstPlayer[0]);

                    cardsFirstPlayer.RemoveAt(0);
                    cardsSecondPlayer.RemoveAt(0);
                }
                else if (cardsFirstPlayer[0] == cardsSecondPlayer[0])
                {
                    cardsFirstPlayer.RemoveAt(0);
                    cardsSecondPlayer.RemoveAt(0);
                }
            }
        }
    }
}
