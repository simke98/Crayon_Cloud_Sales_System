using Crayon.CSS.Application.Services;
using Crayon.CSS.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Crayon.CSS.Service;

public static class ServiceCollectionExtensions
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<ICCPService, CCPService>();
    }
}
