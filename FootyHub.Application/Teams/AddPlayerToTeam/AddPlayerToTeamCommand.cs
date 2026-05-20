using MediatR;

namespace FootyHub.Application.Teams.AddPlayerToTeam;

public class AddPlayerToTeamCommand : IRequest<bool>
{
   public Guid TeamId { get; init; }

    public IEnumerable<Guid> PlayerIds { get; init; } = new List<Guid>();
}
