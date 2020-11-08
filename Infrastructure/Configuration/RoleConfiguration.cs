using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MPPIS.Domain.Entities;

namespace MPPIS.Infrastructure.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");

            builder.Property(p => p.Id)
                .HasColumnName("id");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasMaxLength(50);

        }
    }
}
