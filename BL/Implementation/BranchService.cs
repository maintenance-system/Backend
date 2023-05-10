using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.DTO;
using BL.Interfaces;

namespace BL.Implementation
{
    internal class BranchService : IBranchService
    {
        public Task<int> CreateAsync(BranchDTO item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BranchDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public bool Update(BranchDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
