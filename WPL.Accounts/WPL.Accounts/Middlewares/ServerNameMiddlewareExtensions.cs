using Microsoft.AspNetCore.Builder;

namespace WPL.Accounts.Middlewares
{
    public static class ServerNameMiddlewareExtensions
    {
        public static IApplicationBuilder UseServerName(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ServerNameMiddleware>();
        }
    }
}