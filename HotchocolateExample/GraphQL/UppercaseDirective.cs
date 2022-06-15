namespace HotchocolateExample.GraphQL;

public class UppercaseDirective: DirectiveType
{
    protected override void Configure(IDirectiveTypeDescriptor descriptor)
    {
        descriptor.Name("uppercase");
        descriptor.Description("Takes a string and makes it uppercase.");
        
        // This dictates where the directive can be applied.
        descriptor.Location( DirectiveLocation.ArgumentDefinition | DirectiveLocation.FieldDefinition);
        
        // This is essentially the function which runs when the directive is applied.
        descriptor.Use(next=> async context=>
        { 
            await next(context);

            if(context.Result is string s) 
            {
                context.Result = s.ToUpper();
            }
        });
    }
}