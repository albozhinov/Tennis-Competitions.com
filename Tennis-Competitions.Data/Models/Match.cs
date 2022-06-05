namespace Tennis_Competitions.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Tennis_Competitions.Data.Common;

    public class Match
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; }

        public Guid FirstPlayerId { get; set; }

        public Guid SecondPlayerId { get; set; }

        public string FirstPlayerName { get; set; }

        public string SecondPlayerName { get; set; }

        public Round Round { get; set; }

        public string FirstPlayerResult { get; set; }
        
        public string SecondPlayerResult { get; set; }

        public int AcesFirstPlayer { get; set; }

        public int AcesSecondPlayer { get; set; }

        public int DoubleFoultsFirstPlayer { get; set; }

        public int DoubleFoultsSecondPlayer { get; set; }

        public int WinnersFirstPlayer { get; set; }

        public int WinnersSecondPlayer { get; set; }

        public int UnforcesErrorsFirstPlayer { get; set; }

        public int UnforcesErrorsSecondPlayer { get; set; }

        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
