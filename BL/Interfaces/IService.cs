using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces;

public interface IService<T>
{
    //creat
    Task<int> CreateAsync(T item);

    //Read
    Task<List<T>> GetAllAsync();

    //Update
    bool Update(T item);

    //delete
    Task<bool> DeleteAsync(int id);
}
