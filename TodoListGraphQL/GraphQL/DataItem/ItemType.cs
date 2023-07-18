using TodoListGraphQL.Data;
using TodoListGraphQL.Models;

namespace TodoListGraphQL.GraphQL.DataItem
{
    public class ItemType : ObjectType<ItemList>
    {
        protected override void Configure(IObjectTypeDescriptor<ItemList> descriptor)
        {
            
            descriptor.Description("This model is used as item for the to list");
            descriptor.Field(x => x.ItemDatas)
                        .ResolveWith<Resolvers>(x =>x.data(default!,default!))
                        .UseDbContext<ApiDbContext>()
                        .Description("List where Item belongs");

        }

        private class Resolvers{
            public IQueryable<ItemData> data(ItemList list, [ScopedService] ApiDbContext context){
                return context.Items.Where(x => x.ListId == list.Id);
            }
        }
    }
}