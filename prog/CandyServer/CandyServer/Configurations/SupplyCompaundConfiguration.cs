using CandyServer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CandyServer.Configurations;

public class SupplyCompaundConfiguration : IEntityTypeConfiguration<SupplyCompaund>
{
    public void Configure(EntityTypeBuilder<SupplyCompaund> builder)
    {
        builder.HasKey(o => new { o.Id_Component, o.Id_Supply });

        builder.HasOne(o => o.Supply)
            .WithMany(o => o.SupplyCompaunds);

        builder.HasOne(o => o.Component)
            .WithMany(o => o.SupplyCompaunds);
    }

}
