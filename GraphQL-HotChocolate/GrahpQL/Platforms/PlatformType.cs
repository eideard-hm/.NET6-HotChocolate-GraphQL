using GraphQL_HotChocolate.Models;

namespace GraphQL_HotChocolate.GrahpQL.Platforms
{
    public class PlatformType : ObjectType<Platform>
    {
        protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
        {
            base.Configure(descriptor);
            // give a description about Query
            descriptor.Description("Represent any software or service that has a command line interface CLI");

            // give a description about fields
            descriptor
                .Field(p => p.Name)
                .Description("Platform´s name");

            // ignore some fields from the Schema
            descriptor
                .Field(p => p.LicenseKey)
                .Ignore();
        }
    }
}
