using FootyHub.Domain.ValueObjects;

namespace FootyHub.Domain.Entities;

public class Player
{

    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public Position NaturalPosition { get; set; } = null!;

    public int ShirtNumber { get; set; }

    public int Age { get; set; } 

    public string Nationality { get; set; } = null!;

    public Player() { }

    public Player(string name, Position position)
    {
        Id = Guid.NewGuid();
        Name = name;
        NaturalPosition = position;
    }
}
