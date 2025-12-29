namespace FootyHub.Domain.Entities;

public class TrainingSession
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; }
    public TimeSpan Duration { get; set; }
    public string Description { get; set; } = null!;
}
