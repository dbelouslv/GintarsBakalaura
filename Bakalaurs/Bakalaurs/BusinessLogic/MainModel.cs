using System.Collections.Generic;

namespace Bakalaurs.BusinessLogic.MainModel
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public Team Team { get; set; }
    }

    public class MainInformation
    {
        public List<Player> Players = new List<Player>();
    }

    public class Team
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
