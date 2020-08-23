using Microsoft.AspNetCore.Builder;

namespace API.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptions(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionMiddleware>();    
        }
    }
}