using FootyHub.Application.Players.CreatePlayer;
using FootyHub.Application.Players.GetPlayerProfile;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FootyHub.API.Players.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        private readonly IMediator _mediator;

        public PlayersController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> CreatePlayer(CreatePlayerCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            var players = await _mediator.Send(new GetPlayerProfileQuery());
            return Ok(players);

        }
    }
}
