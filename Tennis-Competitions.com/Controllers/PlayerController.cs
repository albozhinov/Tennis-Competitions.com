namespace Tennis_Competitions.com.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Tennis_Competitions.Services.Contracts;

    public class PlayerController : Controller
    {
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService _playerService)
        {
            playerService = _playerService;
        }

        public async Task<IActionResult> Index()
        {
            var players = await playerService.GetAllPlayers();

            return View(players);
        }
    }
}
