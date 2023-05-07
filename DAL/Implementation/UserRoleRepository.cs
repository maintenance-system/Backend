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

        public bool Delete(UserRole item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserRole>> GetAllAsync()
        {
            return await context.UserRoles.ToListAsync<UserRole>();
        }

        public bool Update(UserRole item)
        {
            throw new NotImplementedException();
        }
    }
}
