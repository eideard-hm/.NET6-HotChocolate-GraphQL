using GraphQL_HotChocolate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL_HotChocolate.DataContext.Configs
{
    public class PlatformConfig : IEntityTypeConfiguration<Platform>
    {
        public void Configure(EntityTypeBuilder<Platform> builder)
        {
            // define primary key
            builder.HasKey(p => p.Id);

            // define datatypes
            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(256);

            builder
                .Property(p => p.LicenseKey)
                .IsRequired()
                .HasMaxLength(250);

            // define relationships
        }
    }
}
