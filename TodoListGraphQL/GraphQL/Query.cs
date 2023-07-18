using TodoListGraphQL.Data;
using TodoListGraphQL.Models;
using HotChocolate;

namespace TodoListGraphQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(ApiDbContext))]
        [UseProjection] //=> we have remove it since we have used explicit resolvers
        [UseFiltering]
        [UseSorting]
        public IQueryable<ItemList> GetLists([ScopedService] ApiDbContext context)
        {
            return context.Lists;
        }

        [UseDbContext(typeof(ApiDbContext))]
        [UseProjection] //=> we have remove it since we have used explicit resolvers
        [UseFiltering]
        [UseSorting]
        public IQueryable<ItemData> GetItems([ScopedService] ApiDbContext context)
        {
            return context.Items;
        }
    }
}