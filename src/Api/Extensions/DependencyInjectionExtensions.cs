using Application.Extensions;

namespace Api.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static WebApplicationBuilder AddExternalServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddApplicationServices();
            return builder;
        }
    }
}
