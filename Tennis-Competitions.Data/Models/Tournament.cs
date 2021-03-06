namespace Tennis_Competitions.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Tennis_Competitions.Data.Common;

    using static DataConstants;

    public class Tournament
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        [Required]
        [StringLength(TournamentNameMaxLength, MinimumLength = TournamentNameMinLength)]
        public string Name { get; set; }

        public Surface Surface { get; set; }

        public string ImageURL { get; set; }

        public ICollection<PlayerTournament> Players { get; set; } = new List<PlayerTournament>();

        public ICollection<TournamentMatch> Matches { get; set; } = new List<TournamentMatch>();
    }
}
