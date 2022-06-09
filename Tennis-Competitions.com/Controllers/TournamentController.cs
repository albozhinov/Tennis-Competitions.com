using Microsoft.AspNetCore.Mvc;
using Tennis_Competitions.Services.Contracts;

namespace Tennis_Competitions.com.Controllers
{
    public class TournamentController : Controller
    {
        private readonly ITournamentService tournamentService;

        public TournamentController(ITournamentService _tournamentService)
        {
            tournamentService = _tournamentService;
        }

        public async Task<IActionResult> Index()
        {
            var tours = await tournamentService.GetAllTournaments();

            return View(tours);
        }
    }
}
