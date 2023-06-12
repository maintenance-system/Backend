using DAL.DataObjects;
using DAL.DataObjects.LogIn;
using DAL.Interfaces;
using DAL.Interfaces.Login;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.LogIn;

internal class UserRoleRepository : IUserRoleRepository
{
    DBContext context;
    public UserRoleRepository(DBContext context)
    {
        this.context = context;
    }
    public async Task<int> CreateAsync(UserRole item)
    {
        var result = context.UserRoles.Add(item);
        await context.SaveChangesAsync();
        return result.Entity.Id;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = context.UserRoles.Where(p => p.Id == id).FirstOrDefault();
        if (result != null)
        {
            context.UserRoles.Remove(result);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<List<UserRole>> GetAllAsync()
    {
        return await context.UserRoles
            .Include(u => u.User)
            .Include(r => r.Role)
            .ToListAsync<UserRole>();
    }

    public async Task<List<Role>> GetRoleByName(string name)
    {
        User user = await context.Users.FirstOrDefaultAsync(u => u.Name == name);

        if (user == null)
        {
            return null;
        }

        List<int> roleIds = await context.UserRoles
            .Where(ur => ur.UserId == user.Id)
            .Select(ur => ur.RoleId)
            .ToListAsync();

        List<Role> roles = await context.Roles
            .Where(r => roleIds.Contains(r.Id))
            .ToListAsync();

        return roles;
    }

        public bool Update(UserRole item)
    {
        throw new NotImplementedException();
    }
}
