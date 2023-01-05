using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestaoDeProdutos.Domain.Mappings;
using GestaoDeProdutos.Repository.Data;
using GestaoDeProdutos.Service.Interfaces;
using GestaoDeProdutos.Service.Services;

namespace GestaoDeProdutos.Extensions;

public static class ServiceExtension
{
    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<RepositoryContext>(
            opts => opts.UseInMemoryDatabase(configuration.GetConnectionString("sqlConnection")));

    public static void ConfigureRepositoryManager(this IServiceCollection services)
        => services.AddTransient<IRepositoryManager, RepositoryManager>();

    public static void ConfigureMapping(this IServiceCollection services)
    {
        services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });
        var mapperConfig = new MapperConfiguration(map =>
        {
            map.AddProfile<ProdutoMappingProfile>();
        });
        services.AddSingleton(mapperConfig.CreateMapper());
    }

    public static void ConfigureControllers(this IServiceCollection services)
    {
        services.AddControllers(config =>
        {
            config.CacheProfiles.Add("120SecondsDuration", new CacheProfile
            {
                Duration = 30
            });
        });
    }

    public static void ConfigureResponseCaching(this IServiceCollection services) => services.AddResponseCaching();
}