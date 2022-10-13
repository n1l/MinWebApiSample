using Microsoft.AspNetCore.Authorization;

namespace CustomerService.Customer;

[HttpPost("customers"), AllowAnonymous]
public class CreateCustomerEndpoint : Endpoint<CreateCustomerRequest, CreateCustomerResponse>
{
    public override async Task HandleAsync(
        CreateCustomerRequest createCustomerRequest,
        CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
            throw new TaskCanceledException();

        var createCustomerResponse = new CreateCustomerResponse
        {
            FullName = "Daniel Vega",
            IsAdult = true
        };

        await SendCreatedAtAsync<GetCustomerEndpoint>(
            new { Id = Guid.NewGuid() }, createCustomerResponse,
            generateAbsoluteUrl: true, cancellation: cancellationToken);
    }
}