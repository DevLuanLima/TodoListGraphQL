using TodoListGraphQL.Data;
using TodoListGraphQL.Models;
using HotChocolate;

namespace TodoListGraphQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(ApiDbContext))]
        [UseProjection] //Link with others
        [UseFiltering]
        [UseSorting]
        public IQueryable<ItemList> list([ScopedService] ApiDbContext context)
        {
            return context.Lists;
        }

        [UseDbContext(typeof(ApiDbContext))]
        [UseProjection] 
        [UseFiltering]
        [UseSorting]
        public IQueryable<ItemData> data([ScopedService] ApiDbContext context)
        {
            return context.Items;
        }
    }
}