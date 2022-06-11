namespace Tennis_Competitions.com.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Tennis_Competitions.Services.Contracts;

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

        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var tour = await tournamentService.GetTournamentById(id);

                return View(tour);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
