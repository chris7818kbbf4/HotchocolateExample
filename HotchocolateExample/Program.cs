using HotchocolateExample.GraphQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddGraphQLServer()
    .AddType<UserType>()
    .AddQueryType<QueryType>()
    .AddDirectiveType<UppercaseDirective>()
    ;

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});


app.Run();