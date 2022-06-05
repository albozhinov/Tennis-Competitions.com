namespace Tennis_Competitions.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Player
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        [Required]
        [StringLength(PlayerNamesMaxLength, MinimumLength = PlayerNamesMinLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(PlayerNamesMaxLength, MinimumLength = PlayerNamesMinLength)]
        public string LastName { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }

        public int TournamentsWins { get; set; }

        public ICollection<PlayerMatch> PlayerMatches { get; set; } = new List<PlayerMatch>();

        public ICollection<PlayerTournament> Tournaments { get; set; } = new List<PlayerTournament>();
    }
}
