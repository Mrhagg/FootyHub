using FootyHub.Application.Common.Interface;
using MediatR;

namespace FootyHub.Application.Teams.AddPlayerToTeam;

public class AddPlayerToTeamHandler : IRequestHandler<AddPlayerToTeamCommand, bool>
{
    private readonly ITeamRepository _teamRepositry;
    private readonly IPlayerRepository _playerRepository;


    public AddPlayerToTeamHandler(ITeamRepository teamRepositry, IPlayerRepository playerRepository)
    {
        _teamRepositry = teamRepositry;
        _playerRepository = playerRepository;
    }

    public async Task<bool> Handle(AddPlayerToTeamCommand request, CancellationToken cancellationToken)
    {
        var team = await _teamRepositry.GetByIdAsync(request.TeamId);
        if (team == null)
        {
            return false;
        }
        var players = await _playerRepository.GetByIdsAsync(request.PlayerIds);
        if (players == null || players.Count == 0)
        {
            return false;
        }
        foreach( var player in players)
        {
            team.AddPlayer(player);
        }

        await _teamRepositry.UpdateAsync(team);

        return true;
    }
   
}
