namespace CustomerService.Customer;

public class CreateCustomerResponse
{
    public string FullName { get; init; } = default!;
    public bool IsAdult { get; init; }
}