using Dotnet_2.APIs.Dtos;

namespace Dotnet_2.APIs;

public interface ICustomersService
{
    /// <summary>
    /// Create one Customer
    /// </summary>
    public Task<CustomerDto> CreateCustomer(CustomerCreateInput customerDto);
    public Task<string> CustomCreate(string data);

    /// <summary>
    /// Delete one Customer
    /// </summary>
    public Task DeleteCustomer(CustomerIdDto idDto);

    /// <summary>
    /// Find many Customers
    /// </summary>
    public Task<List<CustomerDto>> Customers(CustomerFindMany findManyArgs);

    /// <summary>
    /// Get one Customer
    /// </summary>
    public Task<CustomerDto> Customer(CustomerIdDto idDto);

    /// <summary>
    /// Update one Customer
    /// </summary>
    public Task UpdateCustomer(CustomerIdDto idDto, CustomerUpdateInput updateDto);
}
