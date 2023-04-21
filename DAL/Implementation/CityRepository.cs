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

    public bool Delete(City item)
    {
        throw new NotImplementedException();
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

