using CandyServer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CandyServer.Configurations;

public class OrderCompaundConfiguration : IEntityTypeConfiguration<OrderCompaund>
{
    public void Configure(EntityTypeBuilder<OrderCompaund> builder)
    {
        builder.HasKey(o => new { o.Id_Order, o.Id_Candy });

        builder.HasOne(o => o.Candy)
            .WithMany(o => o.OrderCompaunds);

        builder.HasOne(o => o.Order)
            .WithMany(o => o.OrderCompaunds);
    }

}
