namespace Tennis_Competitions.Services.Contracts
{
    using Tennis_Competitions.Services.Models;

    public interface IMatchService
    {
        Task<MatchServiceModel> GetMatchById(string id);
    }
}
