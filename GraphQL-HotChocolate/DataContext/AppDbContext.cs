using GraphQL_HotChocolate.DataContext.Configs;
using GraphQL_HotChocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_HotChocolate.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Command> Commands { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // add customs configurations
            builder.ApplyConfiguration(new PlatformConfig());
        }
    }
}
