﻿namespace Tennis_Competitions.Services.Contracts
{
    using System.Threading.Tasks;
    using Tennis_Competitions.Services.Models;

    public interface IPlayerService
    {
        Task<PlayerServiceModel> GetPlayerById(string id);
    }
}