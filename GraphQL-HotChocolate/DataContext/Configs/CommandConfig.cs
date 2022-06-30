using GraphQL_HotChocolate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL_HotChocolate.DataContext.Configs
{
    public class CommandConfig : IEntityTypeConfiguration<Command>
    {
        public void Configure(EntityTypeBuilder<Command> builder)
        {
            // define primary key
            builder.HasKey(c => c.Id);

            // define datatypes
            builder
                .Property(c => c.HowTo)
                .IsRequired()
                .HasMaxLength(800);

            builder
                .Property(c => c.CommandLine)
                .IsRequired()
                .HasMaxLength(200);

            // define relationships
            builder
                .HasOne(c => c.Platform)
                .WithMany(p => p.Commands);
        }
    }
}
