namespace Dotnet_2.APIs.Dtos;

public class CustomerDto : CustomerIdDto
{
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? Birthate { get; set; }
}
