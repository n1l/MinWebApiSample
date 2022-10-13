namespace CustomerService.Customer;

public class GetCustomerResponse
{
    public string FullName { get; init; } = default!;
    public bool IsAdult { get; init; }
}