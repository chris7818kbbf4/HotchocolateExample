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
        descriptor.Use(next=>context=>
        {

            var originalValue = context.Selection.Field.Resolver.Invoke(context).Result as string;

            context.Result = originalValue.ToUpper();
            
            return next(context);
        });
    }
}