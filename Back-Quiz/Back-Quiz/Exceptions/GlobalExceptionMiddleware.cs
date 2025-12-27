using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Back_Quiz.Exceptions;

public class GlobalExceptionMiddleware
{
    private readonly RequestDelegate _next;
    
    public GlobalExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (CustomExceptions ex)
        {
            var problem = new ProblemDetails
            {
                Type = ex.Type,
                Title = ex.Title,
                Status = (int)ex.StatusCode,
                Detail = ex.Message
            };

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)ex.StatusCode;
            await context.Response.WriteAsJsonAsync(new
            {
                ex.Message,
                problem
            });
        }
    }
}