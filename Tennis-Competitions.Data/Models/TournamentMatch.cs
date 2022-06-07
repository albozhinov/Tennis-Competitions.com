namespace Tennis_Competitions.Data.Models
{
    public class TournamentMatch
    {
        public Guid MatchId { get; set; }

        public Guid TournamentId { get; set; }

        public Match Match { get; set; }

        public Tournament Tournament { get; set; }
    }
}
