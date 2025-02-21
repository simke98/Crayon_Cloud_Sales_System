using Crayon.CSS.Api.Middleware;

namespace Crayon.CSS.Api.Extensions;

public static class ExceptionExtension
{
    public static void UseCustomExceptionMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
    }
}
