using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;

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
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "STUDYstics API docs");
});

app.MapGet("/{id}", (int id) => $"Hello World! {id}");

app.Run();
