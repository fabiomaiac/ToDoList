using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ToDo.Data.Context;
using ToDo.Data.Repository;
using ToDo.Domain.Interfaces.Repository;
using ToDo.Domain.Interfaces.Service;
using ToDo.Domain.Models;
using ToDo.Service.Configurations;
using ToDo.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
     .AddJsonFile("appsettings.json");

var connectionString = builder.Configuration.GetConnectionString("Test");

builder.Services.AddCors();

builder.Services.AddDbContext<ToDoContext>(options =>
    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("ToDo.Api")));

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IToDoRepository, ToDoRepository>();

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IToDoService, ToDoService>();

var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ModelToViewModelProfile());
            });
            IMapper mapper = config.CreateMapper();
            builder.Services.AddSingleton(mapper);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
