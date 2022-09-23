using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Api.Extensions
{
    public static class GlobalExceptionHandlerExtension
    {
        public static void UseGlobalExceptionHandler(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    var response = context.Response;
                    response.ContentType = "application/problem+json";
                    var exceptionHandlerFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var exception = exceptionHandlerFeature?.Error;

                    switch (exception)
                    {
                        default:
                            response.StatusCode = StatusCodes.Status500InternalServerError;
                            await context.Response.WriteAsJsonAsync(new ProblemDetails
                            {
                                Instance = context.Request.HttpContext.Request.Path,
                                Title = "Unhandled error occurred",
                                Status = StatusCodes.Status500InternalServerError,
                                Detail = "Oh No! We are facing an impossible situation and we were not able to process your request. Please, try again in a few minutes."
                            },
                            new JsonSerializerOptions()
                            {
                                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                            });
                            break;
                    }
                });
            });
        }
    }
}
