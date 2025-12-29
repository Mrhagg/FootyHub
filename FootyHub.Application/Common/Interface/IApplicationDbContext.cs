using FootyHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootyHub.Application.Common.Interface;

public interface IApplicationDbContext
{
    DbSet<Player> Players { get; }
    DbSet<Match> Matches { get; }
    DbSet<Team> Teams { get; }
    DbSet<TrainingSession> TrainingSessions { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
