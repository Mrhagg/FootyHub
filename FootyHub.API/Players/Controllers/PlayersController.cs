using Microsoft.AspNetCore.Mvc;

namespace FootyHub.API.Players.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
