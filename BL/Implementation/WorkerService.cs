using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.DTO;
using BL.Interfaces;

namespace BL.Implementation
{
    internal class WorkerService : IWorkerService
    {
        public Task<int> CreateAsync(WorkerDTO item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkerDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public bool Update(WorkerDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
