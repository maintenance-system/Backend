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

internal class RoleRepository : IRoleRepository
{
    DBContext context;
    public RoleRepository(DBContext context)
    {
        this.context = context;
    }
    public async Task<int> CreateAsync(Role item)
    {
        var result = context.Roles.Add(item);
        await context.SaveChangesAsync();
        return result.Entity.Id;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = context.Roles.Where(p => p.Id == id).FirstOrDefault();
        if (result != null)
        {
            context.Roles.Remove(result);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<List<Role>> GetAllAsync()
    {
        return await context.Roles.ToListAsync<Role>();
    }

    public bool Update(Role item)
    {
        throw new NotImplementedException();
    }
}
