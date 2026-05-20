using MediatR;

namespace FootyHub.Application.Players.CreatePlayer;

public class CreatePlayerCommand : IRequest<CreatePlayerResult>
{
    public string FirstName { get; init; } = null!;
    public string LastName { get; init; } = null!;
    public string PositionCode { get; init; } = null!;
    public int ShirtNumber { get; init; }
    public string Nationality { get; init; } = null!;
    public DateTime DateOfBirth { get; init; }
}
