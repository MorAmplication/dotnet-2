using Microsoft.AspNetCore.Mvc;

namespace Dotnet_2.APIs;

[ApiController()]
public class UsersController : UsersControllerBase
{
    public UsersController(IUsersService service)
        : base(service) { }
}
