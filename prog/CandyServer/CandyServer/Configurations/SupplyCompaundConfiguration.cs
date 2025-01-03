using CandyServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CandyServer.Configurations;

public class SupplyCompaundConfiguration : IEntityTypeConfiguration<SupplyCompaund>
{
    public void Configure(EntityTypeBuilder<SupplyCompaund> builder)
    {
        builder.HasKey(o => new { o.ComponentId, o.SupplyId });

        builder.HasOne(o => o.Supply)
            .WithMany(o => o.SupplyCompaunds);

        builder.HasOne(o => o.Component)
            .WithMany(o => o.SupplyCompaunds);
    }

}
