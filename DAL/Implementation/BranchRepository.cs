using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataObjects;
using DAL.Interfaces;

namespace DAL.Implementation
{
    internal class BranchRepository : IBranchRepository
    {
        public Task<int> CreateAsync(Branch item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Branch>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public bool Update(Branch item)
        {
            throw new NotImplementedException();
        }
    }
}
