﻿using HelmerDemo.WebShop.Application.Helpers;

namespace HelmerDemo.WebShop.Application.Middleware
{
    /// <summary>
    /// Generic SecurityMiddleware class, please use specific implementations of this class
    /// </summary>
    public class SecurityMiddleware : IMiddleware
    {
        /// <inheritdoc/>
#pragma warning disable AsyncFixer01 // Unnecessary async/await usage
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            context.Response.OnStarting(
                (state) =>
                {
                    SetSecurityHeaders(context);
                    return Task.FromResult(0);
                },
                context);

            await next(context);
        }
#pragma warning restore AsyncFixer01 // Unnecessary async/await usage

        /// <summary>
        /// A method to set the securityHeaders.
        /// </summary>
        /// <param name="context">The http context.</param>
        public virtual void SetSecurityHeaders(HttpContext context)
        {
            var headers = SecurityHeaderHelper.CommonSecurityHeaders(36000);
            foreach (var header in headers)
            {
                if (!context.Response.Headers.ContainsKey(header.Key))
                {
                    context.Response.Headers.Add(header.Key, header.Value);
                }
            }
        }
    }
}

// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/extensibility?view=aspnetcore-5.0
