namespace Tennis_Competitions.Services.Services
{
    using System.Threading.Tasks;
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

        public Task<MatchServiceModel> GetMatchById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
