namespace HotchocolateExample.GraphQL;

public class UserType:ObjectType<User>
{
    protected override void Configure(IObjectTypeDescriptor<User> descriptor)
    {
        descriptor.Field(x => x.Name).Directive<UppercaseDirective>();
    }
}