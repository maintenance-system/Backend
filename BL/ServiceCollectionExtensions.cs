using BL.Implementation;
using BL.Interfaces;
using BL.Profiles;
using BL.Profiles.LogInProfiles;
using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace BL;

public static class ServiceCollectionExtensions
{
    public static void AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<ICityService, CityService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IUserRoleService, UserRoleService>();
        services.AddScoped<IActionsService, ActionsService>();
        services.AddAutoMapper(typeof(CityAndCityDTO));
        services.AddAutoMapper(typeof(UserAndUserDTO));
        services.AddAutoMapper(typeof(RolesAndRolesDTO));
        services.AddAutoMapper(typeof(UserRoleAndUserRoleDTO));
        services.AddAutoMapper(typeof(ActionsAndActionDTO));

        services.AddRepositories();
    }
}
