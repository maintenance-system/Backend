using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataObjects;
using DAL.Interfaces;

namespace DAL.Implementation;

public class WorkerRepository : IWorkerRepository
{
    public int Creat(Worker item)
    {
        throw new NotImplementedException();
    }


    public bool Delete(Worker item)
    {
        throw new NotImplementedException();
    }



    public Task<List<Worker>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public bool Update(Worker item)
    {
        throw new NotImplementedException();
    }
}

  
