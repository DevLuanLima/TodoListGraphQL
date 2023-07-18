namespace TodoListGraphQL.GraphQL.Items
{
    public record AddItemInput(string title, string description, bool done, int listId);
}