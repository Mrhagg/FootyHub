using FootyHub.Application.Teams.AddPlayerToTeam;
using FootyHub.Application.Teams.CreateTeam;
using FootyHub.Application.Teams.GetTeam;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace FootyHub.API.Teams.Controllers;


[ApiController]
[Route("api/[controller]")]
public class TeamsController : Controller
{

    private readonly IMediator _mediator;

    public TeamsController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost("{teamId}/players")]
    public async Task<IActionResult> AddPlayersToTeam(Guid teamId, [FromBody] System.Collections.Generic.List<Guid> playerIds)
    {
        var command = new AddPlayerToTeamCommand
        {
            TeamId = teamId,
            PlayerIds = playerIds
        };

        var result = await _mediator.Send(command);

        if (!result)
        {
            return BadRequest("Kunde inte lägga till spelarna i laget. Kontrollera att laget och spelarna finns.");
        }

        return Ok("Spelarna har lagts till i laget!");
    }

    [HttpPost]
    public async Task<IActionResult> CreateTeam([FromBody] CreateTeamCommand command)
    {
        var teamId = await _mediator.Send(command);
        return CreatedAtAction(nameof(CreateTeam), new { id = teamId }, new { Id = teamId });
    }

    [HttpGet]
    public async Task<IActionResult> GetTeams()
    {
        var teams = await _mediator.Send(new GetTeamQuery());
        return Ok(teams);
    }
}
