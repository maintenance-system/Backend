using BL.Implementation;
using BL.Interfaces;
using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace BL;

public static class ServiceCollectionExtensions
{
    public static void AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<ICityService, CityService>();
        //services.AddScoped<ICategoryService, CategoryService>();
        //services.AddScoped<IAuthorService,AuthorService>();
        services.AddRepositories();
    }
}
