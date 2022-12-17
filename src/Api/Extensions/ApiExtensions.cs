namespace Api.Extensions
{
    public static class ApiExtensions
    {
        public static WebApplicationBuilder AddApiServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            return builder;
        }

        public static WebApplication UseApiServices(this WebApplication app)
        {
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.UseGlobalExceptionHandler();

            return app;
        }
    }
}
