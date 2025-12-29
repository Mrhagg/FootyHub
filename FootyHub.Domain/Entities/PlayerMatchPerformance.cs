using FootyHub.Domain.ValueObjects;

namespace FootyHub.Domain.Entities;

public class PlayerMatchPerformance
{
    public Guid Id { get; set; }
    public Guid PlayerId { get; set; }
    public Guid MatchId { get; set; }


    public Position PositionAtMatch { get; set; } = null!;

    public PlayerStats Stats { get; set; } = null!;

    public decimal CalcuatedLoad => Stats.MinutesPlayed * PositionAtMatch.GetLoadMultiplier();

    public PlayerMatchPerformance()
    {
        Id = Guid.NewGuid();
    }
}