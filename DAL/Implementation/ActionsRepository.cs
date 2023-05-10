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
    internal class ActionsRepository : IActionsRepository
    {
        DBContext context;
        public ActionsRepository(DBContext context)
        {
            this.context = context;
        }

        public async Task<int> CreateAsync(Actions item)
        {
            var result = context.Actions.Add(item);
            await context.SaveChangesAsync();
            return result.Entity.Id;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = context.Actions.Where(p => p.Id == id).FirstOrDefault();
            if (result != null)
            {
                context.Actions.Remove(result);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Actions>> GetAllAsync()
        {
            return await context.Actions
                    .ToListAsync<Actions>();
        }

        public bool Update(Actions item)
        {
            throw new NotImplementedException();
        }
    }
}
