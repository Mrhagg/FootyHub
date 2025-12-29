using Microsoft.AspNetCore.Mvc;

namespace FootyHub.API.Trainings.Controllers
{
    public class TrainingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
