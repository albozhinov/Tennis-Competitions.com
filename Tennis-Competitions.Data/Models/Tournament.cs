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

        public ICollection<Player> Players { get; set; } = new List<Player>();

        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}
