using Microsoft.AspNetCore.Mvc;

namespace Tennis_Competitions.com.Controllers
{
    public class MatchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
