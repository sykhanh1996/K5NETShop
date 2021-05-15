using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K5NETShop.BackendServer.API.Helpers;
using Microsoft.AspNetCore.Builder;

namespace K5NETShop.BackendServer.API.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorWrapping(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorWrappingMiddleware>();
        }
    }
}
