using Microsoft.AspNetCore.Authorization;

namespace CustomerService.Customer;

[HttpGet("customers/{id:guid}"), AllowAnonymous]
public class GetCustomerEndpoint : Endpoint<GetCustomerRequest, GetCustomerResponse>
{
    public override async Task HandleAsync(
        GetCustomerRequest getCustomerRequest,
        CancellationToken cancellationToken)
    {
        var getCustomerResponse = new GetCustomerResponse
        {
            FullName = "Daniel Vega",
            IsAdult = true
        };

        await SendOkAsync(getCustomerResponse, cancellationToken);
    }
}