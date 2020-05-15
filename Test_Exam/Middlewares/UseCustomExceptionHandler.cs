using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using TestExam.Domain.ViewModel;
using TestExam.Service.CustomException;

namespace Test_Exam.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class UseCustomExceptionHandler
    {
        private readonly RequestDelegate _next;

        public UseCustomExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (CustomHttpException ex)
            {
              
                await HandleExceptionAsync(httpContext, ex);
            }
            catch (Exception ex)
            {
               
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            int statusCode = (int)HttpStatusCode.InternalServerError;
            if (ex is CustomHttpException)
            {
                CustomHttpException se = ex as CustomHttpException;
                statusCode = se.GetHttpCode();
            }
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;
            var result = new CustomExceptionResponseDto { Message = ex.Message, MessageCode = statusCode };


            return context.Response.WriteAsync(JsonConvert.SerializeObject(result));
        }
    }

  
}
