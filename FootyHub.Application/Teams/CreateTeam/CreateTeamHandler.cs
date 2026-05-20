using FootyHub.Application.Common.Interface;
using FootyHub.Domain.Entities;
using MediatR;

namespace FootyHub.Application.Teams.CreateTeam;

public class CreateTeamHandler : IRequestHandler<CreateTeamCommand, Guid>
{
    private readonly ITeamRepository _teamRepository;

    public CreateTeamHandler(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }

    public async Task<Guid> Handle (CreateTeamCommand request, CancellationToken cancellationToken)
    {
        var team = new Team(request.Name);
        await _teamRepository.AddAsync(team);
        return team.Id;
    }
}
