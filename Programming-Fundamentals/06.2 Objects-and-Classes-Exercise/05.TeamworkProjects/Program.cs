using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Team> listOfTeams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] teamProperties = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string creator = teamProperties[0];
                string teamName = teamProperties[1];
                
                
                if (listOfTeams.Any(team => team.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (listOfTeams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(creator, teamName, new List<string>());

                    listOfTeams.Add(team);

                    Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
                }
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] cmds = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string user = cmds[0];
                string teamName = cmds[1];

                if (! listOfTeams.Any(team => team.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (listOfTeams.Any(team => team.Members.Contains(user)) || listOfTeams.Any(team => team.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team currTeam = listOfTeams.Find(team => team.TeamName == teamName);
                    currTeam.Members.Add(user);
                }

                input = Console.ReadLine();
            }

            List<Team> completedTeams = listOfTeams.Where(team => team.Members.Count > 0).ToList();
            List<Team> disbanedTeams = listOfTeams.Where(team => team.Members.Count == 0).ToList();

            
            foreach (var team in completedTeams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(team => team))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            
            if (disbanedTeams != null)
            {
                foreach (var team in disbanedTeams.OrderBy(team => team.TeamName))
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }
    }


    class Team
    {
        public Team(string creator, string teamName, List<string> members)
        {
            this.Creator = creator;
            this.TeamName = teamName;
            this.Members = members;
        }
        
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
}
