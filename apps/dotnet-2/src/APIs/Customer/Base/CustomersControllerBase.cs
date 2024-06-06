using Dotnet_2.APIs;
using Dotnet_2.APIs.Dtos;
using Dotnet_2.APIs.Errors;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_2.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CustomersControllerBase : ControllerBase
{
    protected readonly ICustomersService _service;

    public CustomersControllerBase(ICustomersService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Customer
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<CustomerDto>> CreateCustomer(CustomerCreateInput input)
    {
        var customer = await _service.CreateCustomer(input);

        return CreatedAtAction(nameof(Customer), new { id = customer.Id }, customer);
    }

    [HttpPost()]
    public async Task CreateCustomer()
    {
        return await _service.CreateCustomer();
    }

    [HttpGet()]
    public async Task<string> CustomCreate([HttpBody()] string data)
    {
        return await _service.CustomCreate(data);
    }

    [HttpGet()]
    public async Task CustomersMeta()
    {
        return await _service.CustomersMeta();
    }

    [HttpDelete()]
    public async Task DeleteCustomer()
    {
        return await _service.DeleteCustomer();
    }

    [HttpGet()]
    public async Task Customers()
    {
        return await _service.Customers();
    }

    [HttpGet()]
    public async Task Customer()
    {
        return await _service.Customer();
    }

    [HttpPatch()]
    public async Task UpdateCustomer()
    {
        return await _service.UpdateCustomer();
    }

    /// <summary>
    /// Delete one Customer
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteCustomer([FromRoute()] CustomerIdDto idDto)
    {
        try
        {
            await _service.DeleteCustomer(idDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Customers
    /// </summary>
    [HttpGet()]
    public async Task<ActionResult<List<CustomerDto>>> Customers(
        [FromQuery()] CustomerFindMany filter
    )
    {
        return Ok(await _service.Customers(filter));
    }

    /// <summary>
    /// Get one Customer
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<CustomerDto>> Customer([FromRoute()] CustomerIdDto idDto)
    {
        try
        {
            return await _service.Customer(idDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Customer
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateCustomer(
        [FromRoute()] CustomerIdDto idDto,
        [FromQuery()] CustomerUpdateInput customerUpdateDto
    )
    {
        try
        {
            await _service.UpdateCustomer(idDto, customerUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
