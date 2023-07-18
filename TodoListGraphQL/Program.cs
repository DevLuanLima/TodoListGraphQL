using Microsoft.EntityFrameworkCore;
using TodoListGraphQL.Data;
using TodoListGraphQL.GraphQL;
using TodoListGraphQL.GraphQL.Items;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //Add Connection String 
        var connectionString = builder.Configuration.GetConnectionString("Default");

        //This way EF not allow more than one request at same endpoint
        //To solve this issue you must use AddPooledDbContextFactory
        //builder.Services.AddDbContext<ApiDbContext>(o => o.UseSqlServer(connectionString));
        builder.Services.AddPooledDbContextFactory<ApiDbContext>(o => o.UseSqlServer(connectionString));

     
       // Adding GraphQL
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddGraphQLServer()
                        .AddQueryType<Query>()
                        .AddType<ListType>()
                        .AddType<ItemType>()
                        .AddMutationType<Mutation>()
                        .AddProjections()
                        .AddSorting()
                        .AddFiltering();

        builder.Services.AddScoped<Query>();

        var app = builder.Build();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGraphQL();
        });

        app.Run();
    }
}