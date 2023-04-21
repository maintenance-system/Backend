using BL.Implementation;
using BL.Interfaces;
using BL.Profiles;
using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace BL;

public static class ServiceCollectionExtensions
{
    public static void AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<ICityService, CityService>();
        services.AddAutoMapper(typeof(WorkerAndWorkerDTO));
        //services.AddScoped<ICategoryService, CategoryService>();
        //services.AddScoped<IAuthorService,AuthorService>();
        services.AddRepositories();
    }
}
