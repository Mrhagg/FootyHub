using FootyHub.Application.Common.Interface;
using FootyHub.Domain.Entities;
using MediatR;

namespace FootyHub.Application.Players.GetPlayerProfile;

public class GetPlayerProfileQuery : IRequest<List<Player>>
{

}

public class GetPlayerProfileQueryHandler : IRequestHandler<GetPlayerProfileQuery, List<Player>>
{
    private readonly IPlayerRepository _playerRepository;
    public GetPlayerProfileQueryHandler(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }
    
    public async Task<List<Player>> Handle (GetPlayerProfileQuery request, CancellationToken cancellationToken)
    {
        return await _playerRepository.GetAllAsync();
    }
}
