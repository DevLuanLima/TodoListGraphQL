using TodoListGraphQL.Models;

namespace TodoListGraphQL.GraphQL
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public ItemList OnListAdded([EventMessage] ItemList list) => list;

    }
}