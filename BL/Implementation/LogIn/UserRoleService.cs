using AutoMapper;
using BL.DTO.LogIn;
using BL.Interfaces.LogIn;
using DAL.DataObjects.LogIn;
using DAL.Interfaces.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation.LogIn;

internal class UserRoleService : IUserRoleService
{
    IUserRoleRepository userRoleRepository;
    IMapper mapper;
    public UserRoleService(IUserRoleRepository userRoleRepository, IMapper mapper)
    {
        this.userRoleRepository = userRoleRepository;
        this.mapper = mapper;
    }
    public async Task<int> CreateAsync(UserRoleDTO item/*, string password*/)
    {
        UserRole userRole = mapper.Map<UserRole>(item);
        return await userRoleRepository.CreateAsync(userRole);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await userRoleRepository.DeleteAsync(id);
    }

    public async Task<List<UserRoleDTO>> GetAllAsync()
    {
        List<UserRole> userRole = await userRoleRepository.GetAllAsync();
        List<UserRoleDTO> userRoleDtos = mapper.Map<List<UserRoleDTO>>(userRole);

        return userRoleDtos;
    }

    public async Task<List<RoleDTO>> GetRoleByName(string name)
    {
        List<Role> role = await userRoleRepository.GetRoleByName(name);
        List<RoleDTO> roleDtos = mapper.Map<List<RoleDTO>>(role);

        return roleDtos;
    }

    public bool Update(UserRoleDTO item)
    {
        throw new NotImplementedException();
    }
}
