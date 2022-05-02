using Demo.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
  .AddQueryType<BookQuery>();

var app = builder.Build();

app.MapGraphQL();

app.Map("/", () => "append to the URL: /graphql");

app.Run();
