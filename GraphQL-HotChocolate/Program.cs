using GraphQL.Server.Ui.Voyager;
using GraphQL_HotChocolate.DataContext;
using GraphQL_HotChocolate.GrahpQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add DbContext
builder.Services.AddPooledDbContextFactory<AppDbContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("CommandConnection"))
);

// add GraphQL configuration
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGraphQL();

app.UseGraphQLVoyager(new VoyagerOptions { GraphQLEndPoint = "/graphql" }, "/graphql-voyager");

app.UseAuthorization();

app.MapControllers();

app.Run();
