namespace Tennis_Competitions.Data.Models
{
    public class PlayerMatch
    {
        public Guid PlayerId { get; set; }

        public Player Player { get; set; }

        public Guid MatchId { get; set; }

        public Match Match { get; set; }
    }
}
