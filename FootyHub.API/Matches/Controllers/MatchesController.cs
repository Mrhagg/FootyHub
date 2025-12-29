using Microsoft.AspNetCore.Mvc;

namespace FootyHub.API.Matches.Controllers;

public class MatchesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
