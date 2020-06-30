﻿using Keezag.Common.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace Keezag.Common
{
    public static class ExceptionHandlerInitializer
    {
        public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<GlobalExceptionMiddleware>();
        }
    }
}
