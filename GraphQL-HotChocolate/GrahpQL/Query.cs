using GraphQL_HotChocolate.DataContext;
using GraphQL_HotChocolate.Models;

namespace GraphQL_HotChocolate.GrahpQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<Platform> GetPlatforms([ScopedService] AppDbContext context) => context.Platforms;

        [UseDbContext(typeof (AppDbContext))]
        [UseProjection]
        public IQueryable<Command> GetCommands([ScopedService] AppDbContext context) => context.Commands;
    }
}
