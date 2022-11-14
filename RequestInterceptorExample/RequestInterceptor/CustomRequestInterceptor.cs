using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace RequestInterceptorExample.RequestInterceptor
{
    public class CustomRequestInterceptor: ControllerBase
    {
        private readonly RequestDelegate _next;

        public CustomRequestInterceptor(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            throw new UnauthorizedAccessException("You are not Authorized");
            await _next.Invoke(context);
        }
    }

    public static class CustomMiddlewareExtensions
    {
        public static IApplicationBuilder CustomRequestInterceptor(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomRequestInterceptor>();
        }
    }
}
