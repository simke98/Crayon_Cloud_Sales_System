using Crayon.CSS.Application.Repositories;
using Crayon.CSS.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Crayon.CSS.Persistence;

public static class ServiceCollectionExtensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICustomerRepository, CustomerRepository>();
    }
}