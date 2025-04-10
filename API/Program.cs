using CORE.Interfaces.Respositorio;
using CORE.Interfaces.Service;
using CORE.Service;
using CORE.Util;
using INFRE;
using INFRE.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var cadena = CadenaConexion.GetCadena();
builder.Services.AddDbContext<MiBase>(option => option.UseSqlServer(cadena));

builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<IProductoRespositorio, ProductoRespositorio>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
