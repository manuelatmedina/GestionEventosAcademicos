using GestionEventosAcademicos.API.Data;
using GestionEventosAcademicos.WEB.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyecci�n de dependencias a SQL Server
builder.Services.AddDbContext<DataContext>(x=>x.UseSqlServer("name=DefaultConnection"));

// Inyecci�n de dependencias a la WEB
builder.Services.AddScoped(sp=>new HttpClient { BaseAddress=new Uri ("https://localhost:8000")});

builder.Services.AddScoped<IRepository,Repository>();

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

app.MapControllers();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());

app.Run();