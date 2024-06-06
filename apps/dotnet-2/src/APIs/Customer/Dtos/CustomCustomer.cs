using System.ComponentModel.DataAnnotations;

namespace Dotnet_2.APIs;

public class CustomCustomer
{
    [Required()]
    public string FirstName { get; set; }

    [Required()]
    public string LastName { get; set; }

    [Required()]
    public DateTime Birthdate { get; set; }
}
