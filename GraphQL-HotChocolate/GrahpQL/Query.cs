using GraphQL_HotChocolate.DataContext;
using GraphQL_HotChocolate.Models;

namespace GraphQL_HotChocolate.GrahpQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context) => context.Platforms;
    }
}
