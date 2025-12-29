using FootyHub.Domain.ValueObjects;

namespace FootyHub.Domain.Entities;

public class Match
{
    public Guid Id { get; set; }

    public DateTime KickOff { get; set; }

    public Guid HomeTeamId { get; set; }

    public Guid AwayTeamid { get; set; }


    public List<PlayerMatchPerformance> Performances { get; set; } = new();

    public void AddPlayerPerformance(Player player, Position position, int goals,int assists, int minutes)
    {
        if (minutes > 120)
            throw new ArgumentException("Minutes played cannot exceed 120 minutes.");

        if (Performances.Any(p => p.PlayerId == player.Id))
            throw new InvalidOperationException($"Player {player.Name} is already registered for this match.");

        var performance = new PlayerMatchPerformance
        {
            PlayerId = player.Id,
            MatchId = this.Id,
            PositionAtMatch = position,
            Stats = new PlayerStats(goals, assists, minutes)
        };

        Performances.Add(performance);
    }
}
