namespace Tennis_Competitions.com.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Tennis_Competitions.Services.Contracts;

    public class MatchController : Controller
    {
        private readonly IMatchService matchService;

        public MatchController(IMatchService _matchService)
        {
            matchService = _matchService;
        }

        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var match = await matchService.GetMatchById(id);

                return View(match);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
