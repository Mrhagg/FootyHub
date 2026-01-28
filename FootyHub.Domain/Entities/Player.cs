using FootyHub.Domain.ValueObjects;

namespace FootyHub.Domain.Entities;

public class Player
{
    private Player() { }

    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Position NaturalPosition { get; set; } = null!;
    public int ShirtNumber { get; set; }
    public string Nationality { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }

    public Player(
        string firstName,
        string lastName,
        Position naturalPosition,
        int shirtNumber,
        string nationality,
        DateTime dateOfBirth)
        
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            NaturalPosition = naturalPosition;
            ShirtNumber = shirtNumber;
            Nationality = nationality;
            DateOfBirth = dateOfBirth;
        }

    public int Age => DateTime.Now.Year - DateOfBirth.Year;


}
