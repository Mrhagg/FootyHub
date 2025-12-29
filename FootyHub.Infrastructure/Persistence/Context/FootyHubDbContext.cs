using FootyHub.Application.Common.Interface;
using FootyHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootyHub.Infrastructure.Persistence.Context;

public class FootyHubDbContext : DbContext, IApplicationDbContext
{
    public FootyHubDbContext(DbContextOptions<FootyHubDbContext> options)
        : base(options)
    {
    }

    public DbSet<Player> Players => Set<Player>();
    public DbSet<Match> Matches => Set<Match>();

    public DbSet<Team> Teams => Set<Team>();

    public DbSet<TrainingSession> TrainingSessions => Set<TrainingSession>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FootyHubDbContext).Assembly);
    }
}
