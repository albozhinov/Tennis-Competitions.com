namespace Tennis_Competitions.Services.Services
{
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    using Tennis_Competitions.Data.Models;
    using Tennis_Competitions.Data.Repository;
    using Tennis_Competitions.Services.Contracts;
    using Tennis_Competitions.Services.Models;
    using Tennis_Competitions.Services.Providers;

    public class MatchService : IMatchService
    {
        private readonly IRepository repository;
        private readonly IValidatorService validator;

        public MatchService(IRepository _repository, IValidatorService _validatorService)
        {
            this.repository = _repository;
            this.validator = _validatorService;
        }

        public async Task<MatchServiceModel> GetMatchById(string id)
        {
            validator.NullOrWhiteSpacesCheck(id);

            var isValidId = validator.TryParseGuid(id);

            if (!isValidId.Item1)
                throw new ArgumentException("Incorrect ID.");


            var match = await repository.All<Match>()
                                               .FirstOrDefaultAsync(m => m.Id == isValidId.Item2);

            if (match == null)
                throw new ArgumentException("Match cannot be found.");

            return new MatchServiceModel(match);
        }
    }
}
