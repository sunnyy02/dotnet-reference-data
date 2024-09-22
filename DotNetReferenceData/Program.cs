using DotNetReferenceData.repo.Interface;
using DotNetReferenceData.Services;
using DotNetReferenceData.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;

namespace DotNetReferenceData;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<IRepositoryBase<CountryDataDto>, CountryRepository>();
        builder.Services.AddScoped<IRepositoryBase<IndustryDataDto>, IndustryRepository>();
        builder.Services.AddScoped<IReferenceDataService, ReferenceDataService>();
        builder.Services.AddKeyedScoped<IRefdataStrategy, IndustryTypeStrategy>("industry");
        builder.Services.AddKeyedScoped<IRefdataStrategy, CountryTypeStrategy>("country");

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
    }
}


