using Dotnet_2.Infrastructure;

namespace Dotnet_2.APIs;

public class UsersService : UsersServiceBase
{
    public UsersService(Dotnet_2DbContext context)
        : base(context) { }
}
