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
    public int Creat(City item)
    {
        throw new NotImplementedException();
    }

    public bool Delete(City item)
    {
        throw new NotImplementedException();
    }

    public async Task<List<City>> Read()
    {
        return await context.Cities
           .ToListAsync<City>();
    }

    public bool Update(City item)
    {
        throw new NotImplementedException();
    }


}

