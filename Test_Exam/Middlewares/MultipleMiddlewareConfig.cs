using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Exam.Middlewares
{
    public static class MultipleMiddlewareConfig
    {
        public static IApplicationBuilder UseCustomMultipleHandler(
   this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UseCustomExceptionHandler>();
        }
    }
}
