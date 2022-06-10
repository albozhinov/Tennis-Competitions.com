using Tennis_Competitions.Data.Models;

namespace Tennis_Competitions.Services.Models
{
    public class PlayerServiceModel
    {
        public PlayerServiceModel()
        {

        }

        public PlayerServiceModel(Player player)
        {
            this.Id = player.Id;
            this.FirstName = player.FirstName;
            this.LastName = player.LastName;
            this.Wins = player.Wins;
            this.Loses = player.Loses;
            this.TournamentsWins = player.TournamentsWins;
            this.ImageURL = player.ImageURL;

            if(player.PlayerMatches is not null)
            this.Matches = player.PlayerMatches
                                            .Select(pm => new MatchServiceModel(pm.Match))
                                            .ToList();

            if (player.Tournaments is not null)
                this.Tournaments = player.Tournaments
                                                .Select(t => new TournamentServiceModel(t.Tournament))
                                                .ToList();
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }

        public int TournamentsWins { get; set; }

        public string ImageURL { get; set; }

        public ICollection<MatchServiceModel> Matches { get; set; }

        public ICollection<TournamentServiceModel> Tournaments { get; set; }
    }
}
