using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "STUDYstics API", Description = "CRUD operation for STUDYstics DB", Version = "v1" });
    });


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/schema/swagger/swagger.json", "STUDYstics API docs");
});

app.MapGet("/", () => "Hello World!");

app.Run();
