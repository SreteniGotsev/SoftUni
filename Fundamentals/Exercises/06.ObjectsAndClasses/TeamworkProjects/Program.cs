using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator = input[0];
                string team = input[1];

                Team currentTeam = new Team(team, creator);

                if (!teams.Select(x => x.TeamName).Contains(team))
                {
                    if (teams.Select(x => x.TeamName).Contains(creator))
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                    else
                    {
                        teams.Add(currentTeam);
                        Console.WriteLine($"Team {team} has been created by {creator}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
            }

            string comand = Console.ReadLine();

            while (comand != "end of assignment")
            {
                string[] input = comand.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string member = input[0];
                string preference = input[1];

                if (teams.Select(x => x.TeamName).Contains(preference))
                {
                    if (teams.Select(x => x.Members).Any(x => x.Contains(member)) || teams.Select(x => x.TeamCreator).Contains(member))
                    {
                        Console.WriteLine($"Member {member} cannot join team {preference}!");
                    }
                    else
                    {
                        int index = teams.FindIndex(x => x.TeamName == preference);
                        teams[index].Members.Add(member);
                    }
                }
                else
                {
                    Console.WriteLine($"Team {preference} does not exist!");
                }

                comand = Console.ReadLine();
            }

            Team[] disbanded = teams.OrderBy(x => x.TeamName)
                                    .Where(x => x.Members.Count == 0)
                                    .ToArray();

            Team[] fullTeams = teams.OrderByDescending(x => x.Members.Count)
                                    .ThenBy(x => x.TeamName)
                                    .Where(x => x.Members.Count > 0)
                                    .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team team in fullTeams)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"- {team.TeamCreator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }

            sb.AppendLine($"Teams to disband:");

            foreach (var member in disbanded)
            {
                sb.AppendLine(member.TeamName);
            }

            Console.WriteLine(sb.ToString());
        }
    }

    class Team
    {
        public Team(string teamName, string teamCreator)
        {
            TeamName = teamName;
            TeamCreator = teamCreator;
            Members = new List<string>();
        }

        public string TeamName { get; set; }
        public string TeamCreator { get; set; }
        public List<string> Members { get; set; }
    }
}

