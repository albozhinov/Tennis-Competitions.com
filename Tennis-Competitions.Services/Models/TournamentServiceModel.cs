using Tennis_Competitions.Data.Common;
using Tennis_Competitions.Data.Models;

namespace Tennis_Competitions.Services.Models
{
    public class TournamentServiceModel
    {
        public TournamentServiceModel()
        {

        }

        public TournamentServiceModel(Tournament tournament)
        {
            this.Id = tournament.Id;
            this.Name = tournament.Name;
            this.Surface = tournament.Surface;
            this.ImageURL = tournament.ImageURL;

            if (tournament.Players is not null)
            this.Players = tournament.Players
                                        .Select(p => new PlayerServiceModel(p.Player))
                                        .ToList();

            if (tournament.Matches is not null)
                this.Matches = tournament.Matches
                                        .Select(m => new MatchServiceModel(m.Match))
                                        .ToList();

        }

        public Guid Id { get; init; }

        public string Name { get; set; }

        public Surface Surface { get; set; }

        public string ImageURL { get; set; }

        public ICollection<PlayerServiceModel> Players { get; set; } 

        public ICollection<MatchServiceModel> Matches { get; set; }
    }
}
