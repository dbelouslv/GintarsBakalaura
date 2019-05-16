using System.Collections.Generic;

namespace Bakalaurs.BusinessLogic.MainModel
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public int Points { get; set; }
        public int Missed { get; set; }
        public int REB { get; set; }
        public int AST { get; set; }
        public int Foul { get; set; }
        public Team Team { get; set; }
    }

    public class MainInformation
    {
        public List<Player> Players = new List<Player>();
        public Team FirstTeam;
        public Team SecondTeam;
        public string Time;
        public string Place;
    }

    public class Team
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Points { get; set; }
    }

    public enum PanelType
    {
        Home = 1,
        CreateGame = 2,
        StartGame = 3,
        StatisticOfGame = 4,
        SaveStatistic = 5
    }   
}
