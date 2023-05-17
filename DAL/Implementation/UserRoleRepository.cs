using DAL.DataObjects;
using DAL.DataObjects.LogIn;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
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

        public bool Update(UserRole item)
        {
            throw new NotImplementedException();
        }
    }
}
