namespace Tennis_Competitions.Services.Contracts
{
    using System.Threading.Tasks;
    using Tennis_Competitions.Services.Models;

    public interface IPlayerService
    {
        Task<ICollection<PlayerServiceModel>> GetAllPlayers();

        Task<PlayerServiceModel> GetPlayerById(string id);

        Task<PlayerServiceModel> GetPlayerMatches(string id);

        Task<PlayerServiceModel> GetPlayerTournaments(string id);
    }
}
