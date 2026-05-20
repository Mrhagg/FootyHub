using MediatR;

namespace FootyHub.Application.Teams.CreateTeam;

public class CreateTeamCommand : IRequest<Guid>
{
    public string Name { get; init; } = null!;
}
