using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.DataObjects;
using Microsoft.EntityFrameworkCore;

namespace DAL.Implementation;
public class CityRepository : ICityRepository
{
    DBContext context;
    public CityRepository(DBContext context)
    {
        this.context = context;
    }

    public async Task<int> CreateAsync(City item)
    {
        var result = context.Cities.Add(item);
        await context.SaveChangesAsync();
        return result.Entity.Id;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = context.Cities.Where(p => p.Id == id).FirstOrDefault();
        if (result != null)
        {
            context.Cities.Remove(result);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<List<City>> GetAllAsync()
    {
        return await context.Cities
           .ToListAsync<City>();
    }

    public bool Update(City item)
    {
        throw new NotImplementedException();
    }


}

