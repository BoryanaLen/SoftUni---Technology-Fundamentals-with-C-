using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Play!")
                {
                    Console.WriteLine(string.Join(' ', games));

                    break;
                }

                List<string> inputInfo = input.Split().ToList();

                string command = inputInfo[0];

                string game = inputInfo[1];

                if(command == "Install")
                {
                    if (!games.Contains(game))
                    {
                        games.Add(game);
                    }
                }
                else if(command == "Uninstall")
                {
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                    }
                }
                else if (command == "Update")
                {
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                        games.Add(game);
                    }
                }
                else if (command == "Expansion")
                {
                    List<string> expansionInfo = game.Split('-').ToList();

                    string currentGame = expansionInfo[0];

                    string expansion = expansionInfo[1];

                    if (games.Contains(currentGame))
                    {

                        int index = games.IndexOf(currentGame);

                        string extensionToInsert = $"{currentGame}:{expansion}";

                        games.Insert(index + 1, extensionToInsert);
                    }
                }
            }
        }
    }
}
