using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces;

public interface IService<T>
{
    //creat
    public int Creat(T item);

    //Read
    public Task<List<T>> GetAllAsync();

    //Update
    public bool Update(T item);

    //delete
    public bool Delete(T item);
}
