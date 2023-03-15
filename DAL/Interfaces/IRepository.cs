using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces;

public interface IRepository<T>
{
    //creat
    int Creat(T item);
    
    //Read
    Task<List<T>> GetAllAsync();

    //Update
    bool Update(T item);

    //delete
    bool Delete(T item);                 
}
