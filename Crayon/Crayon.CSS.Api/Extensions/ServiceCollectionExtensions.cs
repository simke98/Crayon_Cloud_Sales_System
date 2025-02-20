using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Crayon.CSS.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddSwaggerSettings(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cloud Sales System", Version = "v1" });
        });
    }
}
