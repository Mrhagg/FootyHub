using FootyHub.Application.Common.Interface;
using FootyHub.Domain.Entities;
using MediatR;

namespace FootyHub.Application.Players.CreatePlayer;

public class CreatePlayerHandler
    : IRequestHandler<CreatePlayerCommand, CreatePlayerResult>
{
    private readonly IPlayerRepository _playerRepository;

    public CreatePlayerHandler(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }

    public async Task<CreatePlayerResult> Handle(
        CreatePlayerCommand request,
        CancellationToken cancellationToken)
    {
        var player = new Player(
            request.FirstName,
            request.LastName,
            request.NaturalPosition,
            request.ShirtNumber,
            request.Nationality,
            request.DateOfBirth
        );

        await _playerRepository.AddAsync(player);

        return new CreatePlayerResult
        {
            PlayerId = player.Id
        };
    }
}
