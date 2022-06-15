namespace HotchocolateExample.GraphQL;

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {
        descriptor.Field(x => x.GetUserByEmail(default!))
            .Argument("email", a=> a.Directive<UppercaseDirective>())
            ;
    }
}

public class Query
{

    public User GetUserByEmail(string email)
    {
        return new User
        {
            Name = "test",
            Email = email
        };
    }
    
}