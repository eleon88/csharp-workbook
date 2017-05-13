using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCreator
{
    class Program
    {

        public static List<Team> teams = new List<Team>();
        static void Main(string[] args)
        {

            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter a command");
                string command = Console.ReadLine().ToLower();
                if (command == "create team")
                {
                    Team team = new Team();
                    team.AddPlayers();
                    teams.Add(team);
                    Console.WriteLine("Team has been created");
                    Console.ReadLine();
                }
                if (command == "teams")
                {
                    Console.WriteLine($"There are {teams.Count()} teams.");
                    for(int i = 0; i <= teams.Count() -1; i++)
                    {
                        Console.WriteLine($"Team: {teams[i].TeamName} {teams[i].Mascot} has {teams[i].players.Count()}");
                        foreach (var player in teams[i].players)
                        {
                            Console.WriteLine($"\t{player.Name}({player.Number}): {player.Position}");
                        }
                    }
                }
                else if (command == "exit")
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                    Console.ReadLine();
                }
            }
        }
    }
}
