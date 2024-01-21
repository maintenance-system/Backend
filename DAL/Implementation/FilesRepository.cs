using DAL.DataObjects;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation;

public class FilesRepository : IFilesRepository
{

    DBContext context;
    public FilesRepository(DBContext context)
    {
        this.context = context;
    }

    public async Task<int> CreateAsync(Files item)
    {
        var result = context.Files.Add(item);
        await context.SaveChangesAsync();
        return result.Entity.Id;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = context.Files.Where(p => p.Id == id).FirstOrDefault();
        if (result != null)
        {
            context.Files.Remove(result);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<List<Files>> GetAllAsync()
    {
        return await context.Files
          .ToListAsync<Files>();
    }

    public async Task<List<Files>> GetByStatusAsync(string status)
    {
        return await context.Files
            .Where(file => file.Status.Equals(status))
            .ToListAsync<Files>();
    }

    public bool Update(Files item)
    {
        throw new NotImplementedException();
    }
}
