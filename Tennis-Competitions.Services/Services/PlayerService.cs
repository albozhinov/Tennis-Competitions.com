namespace Tennis_Competitions.Services.Services
{
    using System.Threading.Tasks;
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

        public Task<PlayerServiceModel> GetPlayerById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
