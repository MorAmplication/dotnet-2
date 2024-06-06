using Dotnet_2.Infrastructure;

namespace Dotnet_2.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(Dotnet_2DbContext context)
        : base(context) { }
}
