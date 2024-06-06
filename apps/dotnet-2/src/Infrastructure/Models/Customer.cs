using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet_2.Infrastructure.Models;

[Table("Customers")]
public class Customer
{
    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? FirstName { get; set; }

    [StringLength(1000)]
    public string? LastName { get; set; }

    public DateTime? Birthate { get; set; }
}
