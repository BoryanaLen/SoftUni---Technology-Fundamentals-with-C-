using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }

                if(input.IndexOf('>') >= 0)
                {
                    List<string> inputInfo = input.Split(" -> ").ToList();

                    string player = inputInfo[0];
                    string position = inputInfo[1];
                    int skills = int.Parse(inputInfo[2]);

                    if (players.ContainsKey(player))
                    {
                        if (players[player].ContainsKey(position))
                        {
                            if(players[player][position] < skills)
                            {
                                players[player][position] = skills;
                            }
                        }
                        else
                        {
                            players[player].Add(position, skills);
                        }
                    }
                    else
                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();
                        current.Add(position, skills);
                        players.Add(player, current);
                    }
                }
                else
                {
                    List<string> inputInfo = input.Split(" vs ").ToList();

                    string playerFirst = inputInfo[0];
                    string playerSecond = inputInfo[1];

                    if(players.ContainsKey(playerFirst) && players.ContainsKey(playerSecond))
                    {
                        int count = 0;

                        foreach(var element in players[playerFirst])
                        {
                            if (players[playerSecond].ContainsKey(element.Key))
                            {
                                count++;
                            }
                        }

                        if(count > 0)
                        {
                            int skillsOne = players[playerFirst].Sum(x => x.Value);
                            int skillsTwo = players[playerSecond].Sum(x => x.Value);

                            if (skillsOne > skillsTwo)
                            {
                                players.Remove(playerSecond);
                            }
                            else if (skillsOne < skillsTwo)
                            {
                                players.Remove(playerFirst);
                            }
                        }
                    }
                }
            }

            players = players.OrderByDescending(x => x.Value.Sum(a => a.Value)).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach(var player in players)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Sum(a => a.Value)} skill");

                var orderedPositions = player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

                foreach(var position in orderedPositions)
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
