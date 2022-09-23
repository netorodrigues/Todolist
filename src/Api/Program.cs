using Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddApiServices();
builder.AddSwaggerService();
builder.AddExternalServices();

var app = builder.Build();

app.UseSwaggerService();
app.UseApiServices();

app.Run();
