using FootyHub.Application.Common.Interface;
using FootyHub.Domain.Entities;
using FootyHub.Domain.ValueObjects;
using MediatR;

namespace FootyHub.Application.Players.CreatePlayer;

public class CreatePlayerHandler
    : IRequestHandler<CreatePlayerCommand, CreatePlayerResult>
{
    private readonly IPlayerRepository _playerRepository;
    private readonly IApplicationDbContext _context;

    public CreatePlayerHandler(IPlayerRepository playerRepository, IApplicationDbContext context)
    {
        _playerRepository = playerRepository;
        _context = context;
       
    }

    public async Task<CreatePlayerResult> Handle(
        CreatePlayerCommand request,
        CancellationToken cancellationToken)
    {
        var position = Position.FromCode(request.PositionCode);

        var player = new Player(
            request.FirstName,
            request.LastName,
            position,
            request.ShirtNumber,
            request.Nationality,
            request.DateOfBirth
        );

        await _playerRepository.AddAsync(player);
        await _context.SaveChangesAsync(cancellationToken);
        return new CreatePlayerResult
        {
            PlayerId = player.Id
        };
    }
}
