namespace Api.Extensions
{
    public static class SwaggerExtensions
    {

        public static WebApplicationBuilder AddSwaggerService(this WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
            return builder;
        }

        public static WebApplication UseSwaggerService(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            return app;
        }
    }
}
