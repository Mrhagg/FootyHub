using FootyHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootyHub.Infrastructure.Persistence.Config;

public class PlayerConfigurations : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.HasKey(x => x.Id);
        builder.OwnsOne(x => x.NaturalPosition, pos =>
        {
            pos.Property(p => p.Code).HasColumnName("PositionCode").IsRequired();
            pos.Property(p => p.DisplayName).HasColumnName("PositionName").IsRequired();
            pos.Property(p => p.Category).HasColumnName("PositionCategory").HasConversion<string>().IsRequired();
        });
    }
}
