﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MPPIS.Domain.Entities;

namespace MPPIS.Infrastructure.Configuration
{
    public class RouteDayConfiguration : IEntityTypeConfiguration<RouteDay>
    {
        public void Configure(EntityTypeBuilder<RouteDay> builder)
        {
            builder.ToTable("RouteDay");

            builder.Property(p => p.Id)
                .IsRequired()
                .HasColumnName("id");

            builder.Property(p => p.Route)
                .IsRequired()
                .HasColumnName("route");
        }
    }
}
