namespace Tennis_Competitions.Data.Models
{
    using System;

    public class PlayerTournament
    {
        public Guid Id { get; set; }

        public Guid PlayerId { get; set; }

        public Guid TournamentId { get; set; }

        public Player Player { get; set; }

        public Tournament Tournament { get; set; }
    }
}
