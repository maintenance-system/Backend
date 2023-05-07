using AutoMapper;
using BL.DTO.LogIn;
using BL.Interfaces;
using DAL.DataObjects.LogIn;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
    internal class UserRoleService : IUserRoleService
    {
        IUserRoleRepository userRoleRepository;
        IMapper mapper;
        public UserRoleService(IUserRoleRepository userRoleRepository, IMapper mapper)
        {
            this.userRoleRepository = userRoleRepository;
            this.mapper = mapper;
        }
        public async Task<int> CreateAsync(UserRoleDTO item)
        {
            UserRole userRole = mapper.Map<UserRole>(item);
            return await userRoleRepository.CreateAsync(userRole);
        }

        public bool Delete(UserRoleDTO item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserRoleDTO>> GetAllAsync()
        {
            List<UserRole> userRole = await userRoleRepository.GetAllAsync();
            List<UserRoleDTO> userRoleDtos = mapper.Map<List<UserRoleDTO>>(userRole);

            return userRoleDtos;
        }

        public bool Update(UserRoleDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
