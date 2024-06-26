using Dotnet_2.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_2.Infrastructure;

public class Dotnet_2DbContext : DbContext
{
    public Dotnet_2DbContext(DbContextOptions<Dotnet_2DbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }

    public DbSet<Customer> Customers { get; set; }
}
