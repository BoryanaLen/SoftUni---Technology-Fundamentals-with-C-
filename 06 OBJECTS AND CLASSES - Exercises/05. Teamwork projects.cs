using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < number; i++)
            {
                List<string> inputTeam = Console.ReadLine().Split('-').ToList();

                string name = inputTeam[1];
                string creator = inputTeam[0];

                int countExistTeam = 0;
                int countExistCreator = 0;

                foreach (Team team in teams)
                {
                    if (team.Name == inputTeam[1])
                    {
                        Console.WriteLine($"Team {inputTeam[1]} was already created!");
                        countExistTeam++;
                    }
                }

                foreach (Team team in teams)
                {
                    if (team.Creator == inputTeam[0])
                    {
                        Console.WriteLine($"{inputTeam[0]} cannot create another team!");
                        countExistCreator++;
                    }
                }

                if (countExistTeam == 0 && countExistCreator == 0)
                {
                    Team createdTeam = new Team(name, creator);

                    teams.Add(createdTeam);

                    Console.WriteLine($"Team {createdTeam.Name} has been created by {createdTeam.Creator}!");
                }
            }

            List<Team> fullTeams = new List<Team>();
            List<Team> notFullTeams = new List<Team>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                List<string> inputUser = input.Split("->").ToList();

                int countExistTeam = 0;
                int indexOfTeam = -1;

                for (int j = 0; j < teams.Count; j++)
                {
                    if (teams[j].Name == inputUser[1])
                    {
                        countExistTeam++;
                        indexOfTeam = j;
                    }
                }

                if (countExistTeam == 0)
                {
                    Console.WriteLine($"Team {inputUser[1]} does not exist!");
                    continue;
                }

                int countIsMember = 0;

                foreach (Team team in teams)
                {
                    if (team.users.Contains(inputUser[0]))
                    {
                        countIsMember++;
                    }

                    if(team.Creator == inputUser[0])
                    {
                        countIsMember++;
                    }
                }

                if (countIsMember > 0)
                {
                    Console.WriteLine($"Member {inputUser[0]} cannot join team {inputUser[1]}!");
                    continue;
                }

                if(countIsMember == 0 && countExistTeam == 1)
                {
                    teams[indexOfTeam].users.Add(inputUser[0]);
                }              
            }

            foreach (Team team in teams)
            {
                if (team.users.Count > 0)
                {
                    fullTeams.Add(team);
                }
                else
                {
                    notFullTeams.Add(team);
                }
            }

            List<Team> orderedTeams = fullTeams.OrderByDescending(order => order.users.Count).
                ThenBy(order => order.Name).ToList();
            List<Team> disbandTeams = notFullTeams.OrderBy(order => order.Name).ToList();

            foreach (Team team in orderedTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                team.users.Sort();

                foreach (string user in team.users)
                {
                    Console.WriteLine($"-- {user}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in disbandTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> users { get; set; }

        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            users = new List<string>();
        }
    }
}
