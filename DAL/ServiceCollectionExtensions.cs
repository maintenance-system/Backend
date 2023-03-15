using DAL.DataObjects;
using DAL.Implementation;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL;
public static class ServiceCollectionExtensions
{        
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICityRepository, CityRepository>();
        //services.AddScoped<ICategoryRepository, CategoryRepository>();
        //services.AddScoped<IAuthorRepository,AuthorRepository>();
        //get the connection string from configuration...
        //calculate relative connection string...
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\Final Project\\C#\\DAL\\DB\\DB.mdf\";Integrated Security=True;Connect Timeout=30";
        services.AddDbContext<DBContext>(options => options.UseSqlServer(connString));
    }

}
