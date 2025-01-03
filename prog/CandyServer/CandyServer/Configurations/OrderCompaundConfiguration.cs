using CandyServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CandyServer.Configurations;

public class OrderCompaundConfiguration : IEntityTypeConfiguration<OrderCompaund>
{
    public void Configure(EntityTypeBuilder<OrderCompaund> builder)
    {
        builder.HasKey(o => new { o.OrderId, o.CandyId });

        builder.HasOne(o => o.Candy)
            .WithMany(o => o.OrderCompaunds);

        builder.HasOne(o => o.Order)
            .WithMany(o => o.OrderCompaunds);
    }

}
