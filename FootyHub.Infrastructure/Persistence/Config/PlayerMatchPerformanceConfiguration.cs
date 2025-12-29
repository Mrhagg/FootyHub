using FootyHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootyHub.Infrastructure.Persistence.Config;

public class PlayerMatchPerformanceConfiguration : IEntityTypeConfiguration<PlayerMatchPerformance>
{
    public void Configure(EntityTypeBuilder<PlayerMatchPerformance> builder)
    {
        builder.HasKey(x => x.Id);
        builder.OwnsOne(x => x.PositionAtMatch, pos =>
        {
            pos.Property(p => p.Code).HasColumnName("MatchPositionCode");
            pos.Property(p => p.DisplayName).HasColumnName("MatchPositionName");
            pos.Property(p => p.Category).HasColumnName("MatchPositionCategory").HasConversion<string>();

        });

        builder.OwnsOne(x => x.Stats, stats =>
        {
            stats.Property(s => s.Goals).HasColumnName("Goals");
            stats.Property(s => s.Assists).HasColumnName("Assists");
            stats.Property(s => s.MinutesPlayed).HasColumnName("MinutesPlayed");
            
        });
    }
}
