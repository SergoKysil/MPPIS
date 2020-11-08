using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MPPIS.Domain.Entities;

namespace MPPIS.Infrastructure.Configuration
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Location");

            builder.Property(p => p.Id)
                .IsRequired()
                .HasColumnName("id");

            builder.Property(p => p.City)
                .IsRequired()
                .HasColumnName("city")
                .HasMaxLength(50);

            builder.Property(p => p.Village)
                .IsRequired()
                .HasColumnName("vilage")
                .HasMaxLength(50);

            builder.Property(p => p.Street)
                .IsRequired()
                .HasColumnName("street")
                .HasMaxLength(50);

            builder.HasMany(d => d.UserLocation)
                .WithOne(p => p.Location)
                .HasForeignKey(k => k.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
