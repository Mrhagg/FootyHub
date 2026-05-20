using FootyHub.Domain.ValueObjects;

namespace FootyHub.App.Models;

public class PlayerDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int ShirtNumber { get; set; }
    public Position NaturalPosition { get; set; } = null!;
    public string Nationality { get; set; } = string.Empty;

    public int Age { get; set; }

}
