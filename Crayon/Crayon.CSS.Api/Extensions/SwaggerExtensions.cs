using Microsoft.OpenApi.Models;

namespace Crayon.CSS.Api.Extensions;

public static class SwaggerExtensions
{
    public static void AddSwaggerSettings(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cloud Sales System", Version = "v1" });
        });
    }

    public static void UseSwaggerSettings(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cloud Sales System API v1");
            c.DocumentTitle = "Cloud Sales System Swagger";
        });
    }
}
