using TodoListGraphQL.Data;
using TodoListGraphQL.Models;

namespace TodoListGraphQL.GraphQL.Lists
{
    public class ListType : ObjectType<ItemList>
    {
        protected override void Configure(IObjectTypeDescriptor<ItemList> descriptor)
        {
            descriptor.Description("List item into groups");

            descriptor.Field(x => x.ItemDatas).Ignore();

            descriptor.Field(x => x.ItemDatas)
                        .ResolveWith<Resolvers>(p => p.GetItems(default!, default!))
                        .UseDbContext<ApiDbContext>()
                        .Description("List of to do item available for this list");
        }

        private class Resolvers
        {
            public IQueryable<ItemData> GetItems(ItemList list, [ScopedService] ApiDbContext context)
            {
                return context.Items.Where(x => x.ListId == list.Id);
            }
        }
    }
}