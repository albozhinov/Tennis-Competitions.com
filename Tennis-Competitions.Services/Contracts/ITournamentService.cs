namespace Tennis_Competitions.Services.Contracts
{
    using System.Threading.Tasks;
    using Tennis_Competitions.Services.Models;

    public interface ITournamentService
    {
        Task<TournamentServiceModel> GetTournamentById(string id);

        Task<TournamentServiceModel> GetAllPlayersInTournament(string tourId);

        Task<TournamentServiceModel> GetAllMatchesInTournament(string tourId);
    }
}
