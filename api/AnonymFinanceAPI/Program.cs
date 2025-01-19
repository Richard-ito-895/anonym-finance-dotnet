using AnonymFinanceAPI.Config;
using AnonymFinanceAPI.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine($"Current Environment: {builder.Environment.EnvironmentName}");

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddOptions<JwtSettingsOptions>()
    .Bind(builder.Configuration.GetSection(JwtSettingsOptions.JwtSettings))
    .ValidateDataAnnotations()
    .ValidateOnStart();

builder.Services.AddDbContext<UsersDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("UsersDatabase"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();