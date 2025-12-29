namespace FootyHub.Domain.ValueObjects;

public sealed class PlayerStats

{
    public int Goals { get; }
    public int Assists { get; }
    public int MinutesPlayed { get; }

    private PlayerStats() { }

    public PlayerStats(int goals, int assists, int minutesPlayed)
    {
        if (goals < 0) throw new ArgumentOutOfRangeException(nameof(goals), "Goals cannot be negative.");
        if (assists < 0) throw new ArgumentOutOfRangeException(nameof(assists), "Assists cannot be negative.");
        if (minutesPlayed < 0) throw new ArgumentOutOfRangeException(nameof(minutesPlayed), "Minutes cannot be negative.");

        Goals = goals;
        Assists = assists;
        MinutesPlayed = minutesPlayed;
    }
}
