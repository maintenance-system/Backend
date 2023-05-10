using DAL.DataObjects;
using DAL.DataObjects.LogIn;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    internal class UserRepository : IUserRepository
    {
        DBContext context;
        public UserRepository(DBContext context)
        {
            this.context = context;
        }
        public async Task<int> CreateAsync(User item)
        {
            var result = context.Users.Add(item);
            await context.SaveChangesAsync();
            return result.Entity.Id;
        }

        public async Task<bool> DeleteAsync(int id)
        {

            var result = context.Users.Where(p => p.Id == id).FirstOrDefault();
            if (result != null)
            {
                context.Users.Remove(result);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await context.Users.ToListAsync<User>();
        }

        public bool Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
