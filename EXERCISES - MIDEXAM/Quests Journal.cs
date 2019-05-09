using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Quests_Journal
{
    class Program
    {
        static bool IsInContent(string quest, List<string> journal)
        {
            int count = 0;

            bool result = false;

            for (int i = 0; i < journal.Count; i++)
            {
                if (journal[i] == quest)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                result = true;
            }

            return result;
        }

        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Retire!")
                {
                    Console.WriteLine(string.Join(", ", journal));
                    break;
                }

                List<string> commands = input.Split(" - ").ToList();

                string command = commands[0];
                string quest = commands[1];

                if (command == "Start")
                {
                    bool isContent = IsInContent(quest, journal);

                    if(isContent == false)
                    {
                        journal.Add(quest);
                    }
                }
                else if(command == "Complete")
                {
                    bool isContent = IsInContent(quest, journal);

                    if (isContent == true)
                    {
                        journal.Remove(quest);
                    }
                }
                else if(command == "Side Quest")
                {
                    List<string> quests = commands[1].Split(':').ToList();

                    string questForCheck = quests[0];
                    string questToAdd = quests[1];

                    bool isQuestExist = IsInContent(questForCheck, journal);

                    bool isSideQuestExist = IsInContent(questToAdd, journal);

                    if(isQuestExist == true && isSideQuestExist == false)
                    {
                        for (int i = 0; i < journal.Count; i++)
                        {
                            if(journal[i] == questForCheck)
                            {
                                journal.Insert(i + 1, questToAdd);
                            }
                        }
                    }
                }
                else if(command == "Renew")
                {
                    bool isContent = IsInContent(quest, journal);

                    if(isContent == true)
                    {
                        journal.Remove(quest);
                        journal.Add(quest);
                    }
                }
            }
        }
    }
}
