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
            this.Players = tournament.Players;
            this.Matches = tournament.Matches;
        }


        public Guid Id { get; init; }

        public string Name { get; set; }

        public Surface Surface { get; set; }

        public ICollection<PlayerTournament> Players { get; set; } = new List<PlayerTournament>();

        public ICollection<TournamentMatch> Matches { get; set; } = new List<TournamentMatch>();
    }
}
