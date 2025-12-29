namespace FootyHub.Domain.Entities;

public class Team
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    
    public List<Player> Players { get; set; } = new();


    public Team(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
        Players = new();
    }

    public void AddPlayer(Player player)
    {
        if (!Players.Contains(player))
        {
            Players.Add(player);
        }
    }

    public void RemovePlayer(Player player)
    {
        Players.Remove(player);
    }

    public bool CanPlayMatch() => Players.Count >= 11;
}
