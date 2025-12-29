using Microsoft.AspNetCore.Mvc;

namespace FootyHub.API.Teams.Controllers;

public class TeamsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
