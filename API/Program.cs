using Domain.RepoInterfaces;
using Infrastructure.DbContext;
using Infrastructure.DbContext.Interfaces;
using Repositories;
using Services;
using Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Services
builder.Services.AddTransient<ICodesService, CodesService>();

// Repositories
builder.Services.AddTransient<ICodesRepository, CodesRepository>();

// Infra
builder.Services.AddTransient<IDbContext>(x => new DbContext("Data Source=DESKTOP-KJ1KTE2\\SQLEXPRESS; Initial Catalog=journey_survey; Persist Security Info=False; User ID=user; Password=user"));

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
