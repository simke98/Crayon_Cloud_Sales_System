using Crayon.CSS.Application.Exceptions;
using Crayon.CSS.Domain.Models;
using System.Net;

namespace Crayon.CSS.Api.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(httpContext, ex);
        }
    }


    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        var statusCode = (int)HttpStatusCode.InternalServerError;
        var message = "Internal Server Error from the custom middleware.";
        var errorCode = "unknow-error";

        switch (exception)
        {
            case NotFoundException ex:
                statusCode = (int)HttpStatusCode.NotFound;
                message = exception.Message;
                errorCode = ex.ErrorCode;
                break;
            case UpdateException ex:
                statusCode = (int)HttpStatusCode.BadRequest;
                message = exception.Message;
                errorCode = ex.ErrorCode;
                break;

        }

        await context.Response.WriteAsync(new ErrorDetails()
        {
            StatusCode = statusCode,
            Message = message,
            ErrorCode = errorCode
        }.ToString() ?? string.Empty);
    }
}
