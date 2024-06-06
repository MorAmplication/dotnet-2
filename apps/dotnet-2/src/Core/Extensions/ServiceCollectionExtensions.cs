using Dotnet_2.APIs;

namespace Dotnet_2;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IUsersService, UsersService>();
        services.AddScoped<ICustomersService, CustomersService>();
    }
}
