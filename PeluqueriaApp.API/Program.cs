using Microsoft.EntityFrameworkCore;
using PeluqueriaApp.AccesoDatos.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<CitasPeluqueriaContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("CN")));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
