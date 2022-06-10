namespace Tennis_Competitions.Services.Services
{
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    using Tennis_Competitions.Data.Models;
    using Tennis_Competitions.Data.Repository;
    using Tennis_Competitions.Services.Contracts;
    using Tennis_Competitions.Services.Models;
    using Tennis_Competitions.Services.Providers;

    public class TournamentService : ITournamentService
    {
        private readonly IRepository repository;
        private readonly IValidatorService validator;

        public TournamentService(IRepository _repository, IValidatorService _validator)
        {
            this.repository = _repository;
            this.validator = _validator;
        }

        public async Task<TournamentServiceModel> GetTournamentById(string id)
        {
            validator.NullOrWhiteSpacesCheck(id);

            (bool, Guid) isGuid = validator.TryParseGuid(id);

            if (!isGuid.Item1)
                throw new ArgumentException("Incorrect ID.");


            var tournament = await repository.All<Tournament>()
                                                .Include(t => t.Matches)
                                                    .ThenInclude(m => m.Match)
                                                .FirstOrDefaultAsync(t => t.Id == isGuid.Item2);

            if (tournament == null)
                throw new ArgumentException("Tournament cannot be found.");

            return new TournamentServiceModel(tournament);
        }

        public async Task<TournamentServiceModel> GetAllPlayersInTournament(string tourId)
        {
            validator.NullOrWhiteSpacesCheck(tourId);

            (bool, Guid) isGuid = validator.TryParseGuid(tourId);

            if (!isGuid.Item1)
                throw new ArgumentException("Incorrect ID.");

            var tournament = await repository.All<Tournament>()
                                             .Include(t => t.Players)
                                                .ThenInclude(p => p.Player)
                                             .FirstOrDefaultAsync(t => t.Id == isGuid.Item2);

            if (tournament == null)
                throw new ArgumentException("Tournament cannot be found.");

            return new TournamentServiceModel(tournament);
        }

        public async Task<TournamentServiceModel> GetAllMatchesInTournament(string tourId)
        {
            validator.NullOrWhiteSpacesCheck(tourId);

            (bool, Guid) isValidId = validator.TryParseGuid(tourId);

            if (!isValidId.Item1)
                throw new ArgumentException("Incorrect ID.");

            var tournament = await repository.All<Tournament>()
                                             .Include(t => t.Matches)
                                             .FirstOrDefaultAsync(t => t.Id == isValidId.Item2);

            if (tournament == null)
                throw new ArgumentException("Tournament cannot be found.");

            return new TournamentServiceModel(tournament);
        }

        public async Task<ICollection<TournamentServiceModel>> GetAllTournaments()
        {
            var tours = await repository.All<Tournament>()
                                                .Select(t => new Tournament()
                                                {
                                                    Id = t.Id,
                                                    Name = t.Name,
                                                    Surface = t.Surface,
                                                    ImageURL = t.ImageURL,
                                                })
                                                .ToListAsync();

            var tournaments = tours.Select(t => new TournamentServiceModel(t)).ToList();

            return tournaments;
        }
    }
}
