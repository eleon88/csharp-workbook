using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCreator
{
    class Team
    {
        public Team()
        {
            CreateTeam();
        }

        private void CreateTeam()
        {
            Console.WriteLine("Enter a team name");
            string TeamName = Console.ReadLine();
            this.TeamName = TeamName;
            Console.WriteLine("Enter a mascot");
            string Mascot = Console.ReadLine();
            this.Mascot = Mascot;
        }

        internal void AddPlayers()
        {
            bool AddPlayerTF = true;
            while (AddPlayerTF)
            {
                Console.WriteLine("Add a player? (yes/no)");
                var command = Console.ReadLine().ToLower();
                if (command == "yes")
                {
                    TeamMember player = new TeamMember();
                    this.players.Add(player);
                }
                else
                {
                    AddPlayerTF = false;
                }
            }
        }

        public string TeamName { get; set; }

        public string Mascot { get; set; }

        public List<TeamMember> players { get; set; } = new List<TeamMember>();

    }
}
