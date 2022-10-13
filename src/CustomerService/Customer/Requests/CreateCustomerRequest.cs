namespace CustomerService.Customer;

public class CreateCustomerRequest
{
    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;
    public int Age { get; init; } = default;
}