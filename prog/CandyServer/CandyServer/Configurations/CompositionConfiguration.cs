﻿using CandyServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CandyServer.Configurations;

public class CompositionConfiguration : IEntityTypeConfiguration<Composition>
{
    public void Configure(EntityTypeBuilder<Composition> builder)
    {
        builder.HasKey(o => new { o.CandyId, o.ComponentId });

        builder.HasOne(o => o.Candy)
            .WithMany(o => o.Compositions);

        builder.HasOne(o => o.Component)
            .WithMany(o => o.Compositions);
    }



}
