using System.Configuration;
using DAL.DataObjects;
using DAL.Implementation;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL;
public static class ServiceCollectionExtensions
{
    static string connString;
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICityRepository, CityRepository>();
        string connString = DBActions.GetConnectionString("Manager");
        services.AddDbContext<DBContext>(options => options.UseSqlServer(connString));
       

    }
   

    public static string GetConnectionString(string connStrNameInCnfig)
    {
        if (connString != null)
        {
            return connString;
        }
        //string conn = ConfigurationManager.ConnectionStrings[connStrNameInCnfig].ConnectionString;
        string connStr = ConfigurationManager.ConnectionStrings[connStrNameInCnfig].ConnectionString;
        connStr = ReplaceWithCurrentLocation(connStr);
        return connStr;
    }

    private static string ReplaceWithCurrentLocation(string connStr)
    {
        string str = AppDomain.CurrentDomain.BaseDirectory;
        string directryAboveBin = str.Substring(0, str.IndexOf("\\bin"));
        string twoDirectoriesAboveBin = directryAboveBin.Substring(0, directryAboveBin.LastIndexOf("\\"));
        connStr = string.Format(connStr, twoDirectoriesAboveBin);
        return connStr;
    }

}
