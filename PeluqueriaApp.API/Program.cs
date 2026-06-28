using Microsoft.EntityFrameworkCore;
using PeluqueriaApp.AccesoDatos.Models;
using PeluqueriaApp.Negocio.Implementaciones;
using PeluqueriaApp.Negocio.Interfaces;
using PeluqueriaApp.Repositorio.Implementaciones;
using PeluqueriaApp.Repositorio.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<CitasPeluqueriaContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("CN")));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
builder.Services.AddScoped<IClienteNegocio, ClienteNegocio>();

builder.Services.AddScoped<IEstilistaRepositorio, EstilistaRepositorio>();
builder.Services.AddScoped<IEstilistaNegocio, EstilistaNegocio>();

builder.Services.AddScoped<IEspecialidadRepositorio, EspecialidadRepositorio>();
builder.Services.AddScoped<IEspecialidadNegocio, EspecialidadNegocio>();

builder.Services.AddScoped<ICitaRepositorio, CitaRepositorio>();
builder.Services.AddScoped<ICitaNegocio, CitaNegocio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
