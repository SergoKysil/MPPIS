using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MPPIS.Domain.Entities;

namespace MPPIS.Infrastructure.Configuration
{
    public class StorageDataConfiguration : IEntityTypeConfiguration<StorageData>
    {
        public void Configure(EntityTypeBuilder<StorageData> builder)
        {
            builder.ToTable("StorageData");

            builder.Property(p => p.Id)
                .IsRequired()
                .HasColumnName("id");

            builder.Property(p => p.DateAdded)
                .IsRequired()
                .HasColumnName("date_added")
                .HasColumnType("date")
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(p => p.CountProduction)
                .IsRequired()
                .HasColumnName("count_production")
                .HasColumnType("decimal");

            builder.HasOne(d => d.User)
                .WithMany(p => p.StorageData)
                .HasForeignKey(k => k.UserId);

        }
    }
}
