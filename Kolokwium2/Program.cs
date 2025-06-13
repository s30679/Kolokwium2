using Kolokwium2.DAL;
using Kolokwium2.Services;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        string? connectionString = builder.Configuration.GetConnectionString("ConnectionStrings");
        // Add services to the container.
        builder.Services.AddAuthorization();
        
        builder.Services.AddControllers();
        builder.Services.AddDbContext<ExhibitionDbContext>(optionsBuilder =>
        {
            optionsBuilder.UseSqlServer(connectionString);
        });
        builder.Services.AddScoped<IExhibitionService, ExhibitionService>();
        
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.Run();
    }
}