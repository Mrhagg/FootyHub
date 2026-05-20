using FootyHub.Application.Common.Interface;
using FootyHub.Domain.Entities;
using MediatR;

namespace FootyHub.Application.Teams.GetTeam;

public class GetTeamQuery : IRequest<List<Team>>
{

}

public class GetTeamQueryHandler : IRequestHandler<GetTeamQuery, List<Team>>
{
    private readonly ITeamRepository _teamRepository;

    public GetTeamQueryHandler(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }

    public async Task<List<Team>> Handle(GetTeamQuery request, CancellationToken cancellationToken)
    {
        return await _teamRepository.GetAllAsync();
    }

}

