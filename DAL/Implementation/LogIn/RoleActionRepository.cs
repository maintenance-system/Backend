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

internal partial class RoleActionRepository : IRoleActionRepository
{
    DBContext context;
    public RoleActionRepository(DBContext context)
    {
        this.context = context;
    }

    public async Task<int> CreateAsync(RolesAction item)
    {
        var result = context.RolesActions.Add(item);
        await context.SaveChangesAsync();
        return result.Entity.Id;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = context.RolesActions.Where(p => p.Id == id).FirstOrDefault();
        if (result != null)
        {
            context.RolesActions.Remove(result);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<List<RolesAction>> GetAllAsync()
    {
        return await context.RolesActions
            .Include(r => r.Role)
            .Include(u => u.ActionsNavigation)
            .ToListAsync<RolesAction>();
    }

    public bool Update(RolesAction item)
    {
        throw new NotImplementedException();
    }
}
