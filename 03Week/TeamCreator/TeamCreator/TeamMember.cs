using System;

namespace TeamCreator
{
    internal class TeamMember
    {
        public TeamMember()
        {
            CreateTeamMember();
        }

        private void CreateTeamMember()
        {
            Console.WriteLine("Enter a player name");
            string Name = Console.ReadLine();
            this.Name = Name;

            Console.WriteLine("Enter a player number");
            int Number = new Random().Next(0, 99);
            int.TryParse(Console.ReadLine(), out Number);
            this.Number = Number;

            Console.WriteLine("Enter a player position");
            string Position = Console.ReadLine();
            this.Position = Position;
        }


        /// <summary>
        /// team name
        /// </summary>
        public string Name { get; set; }

        public int Number { get; set; }

        public string Position { get; set; }
    }
}