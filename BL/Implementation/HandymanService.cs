using BL.DTO;
using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
    internal class HandymanService : IHandymanService
    {
        public Task<int> CreateAsync(HandymanDTO item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(HandymanDTO item)
        {
            throw new NotImplementedException();
        }

        public Task<List<HandymanDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public bool Update(HandymanDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
