namespace Tennis_Competitions.Services.Services
{
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    using Tennis_Competitions.Data.Models;
    using Tennis_Competitions.Data.Repository;
    using Tennis_Competitions.Services.Contracts;
    using Tennis_Competitions.Services.Models;
    using Tennis_Competitions.Services.Providers;

    public class PlayerService : IPlayerService
    {
        private readonly IRepository repository;
        private readonly IValidatorService validator;

        public PlayerService(IRepository _repository, IValidatorService _validator)
        {
            this.repository = _repository;
            this.validator = _validator;
        }

        public async Task<ICollection<PlayerServiceModel>> GetAllPlayers()
        {
            return await repository.All<Player>()
                                            .Select(p => new PlayerServiceModel()
                                            {
                                                Id = p.Id,
                                                FirstName = p.FirstName,
                                                LastName = p.LastName,
                                                ImageURL = p.ImageURL
                                            })
                                            .ToListAsync();
        }

        public async Task<PlayerServiceModel> GetPlayerById(string id)
        {
            validator.NullOrWhiteSpacesCheck(id);

            var isValidId = validator.TryParseGuid(id);

            if (!isValidId.Item1)
                throw new ArgumentException("Incorrect ID.");

            var player = await repository.All<Player>()
                                            .Select(p => new PlayerServiceModel()
                                            {
                                                Id = p.Id,
                                                FirstName = p.FirstName,
                                                LastName= p.LastName,
                                                ImageURL= p.ImageURL,
                                                Wins = p.Wins,
                                                Loses = p.Loses,
                                                TournamentsWins = p.TournamentsWins,
                                                MatchesCount = p.PlayerMatches.Count(),
                                                TournamentsCount = p.Tournaments.Count(),
                                            })
                                            .FirstOrDefaultAsync(p => p.Id == isValidId.Item2);

            if (player is null)
                throw new ArgumentException("Player cannot found.");

            return player;
        }

        public async Task<PlayerServiceModel> GetPlayerMatches(string id)
        {
            validator.NullOrWhiteSpacesCheck(id);

            var isValidId = validator.TryParseGuid(id);

            if (!isValidId.Item1)
                throw new ArgumentException("Incorrect ID.");

            var player = await repository.All<Player>()
                                            .Include(p => p.PlayerMatches)
                                                .ThenInclude(pm => pm.Match)
                                            .FirstOrDefaultAsync(p => p.Id == isValidId.Item2);

            if (player is null)
                throw new ArgumentException("Player cannot found.");


            return new PlayerServiceModel(player);
        }

        public async Task<PlayerServiceModel> GetPlayerTournaments(string id)
        {

            validator.NullOrWhiteSpacesCheck(id);

            var isValidId = validator.TryParseGuid(id);

            if (!isValidId.Item1)
                throw new ArgumentException("Incorrect ID.");

            var player = await repository.All<Player>()
                                            .Include(p => p.Tournaments)
                                                .ThenInclude(t => t.Tournament)
                                            .FirstOrDefaultAsync(p => p.Id == isValidId.Item2);

            if (player is null)
                throw new ArgumentException("Player cannot found.");


            return new PlayerServiceModel(player);
        }
    }
}
