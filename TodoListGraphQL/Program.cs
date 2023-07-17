using Microsoft.EntityFrameworkCore;
using TodoListGraphQL.Data;

var builder = WebApplication.CreateBuilder(args);

//Add Connection String 
var connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<ApiDbContext>(o => o.UseSqlServer(connectionString));

var app = builder.Build();
  
app.Run();
