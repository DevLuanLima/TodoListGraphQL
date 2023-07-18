

using TodoListGraphQL.Data;
using TodoListGraphQL.GraphQL.Items;
using TodoListGraphQL.GraphQL.Lists;
using TodoListGraphQL.Models;

namespace TodoListGraphQL.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(ApiDbContext))]
        public async Task<AddListPayload> AddListAsync(AddListInput input, [ScopedService] ApiDbContext context)
        {
            var list = new ItemList
            {
                Name = input.name
            };

            context.Lists.Add(list);
            await context.SaveChangesAsync();
            return new AddListPayload(list);

          
        }

        [UseDbContext(typeof(ApiDbContext))]
        public async Task<AddItemPayload> AddItemAsync(AddItemInput input, [ScopedService] ApiDbContext context)
        {
            var item = new ItemData
            {
                Description = input.description,
                IsDone = input.done,
                Title = input.title,
                ListId = input.listId
            };

            context.Items.Add(item);
            await context.SaveChangesAsync();

            return new AddItemPayload(item);
        }

    }
}