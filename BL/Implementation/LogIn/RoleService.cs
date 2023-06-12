using AutoMapper;
using BL.DTO.LogIn;
using BL.Interfaces.LogIn;
using DAL.DataObjects.LogIn;
using DAL.Interfaces;
using DAL.Interfaces.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation.LogIn;

internal class RoleService : IRoleService
{
    IRoleRepository roleRepository;
    IMapper mapper;
    public RoleService(IRoleRepository roleRepository, IMapper mapper)
    {
        this.roleRepository = roleRepository;
        this.mapper = mapper;
    }
    public async Task<int> CreateAsync(RoleDTO item)
    {
        Role role = mapper.Map<Role>(item);
        return await roleRepository.CreateAsync(role);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await roleRepository.DeleteAsync(id);
    }

    public async Task<List<RoleDTO>> GetAllAsync()
    {
        List<Role> roles = await roleRepository.GetAllAsync();
        List<RoleDTO> rolesDtos = mapper.Map<List<RoleDTO>>(roles);

        return rolesDtos;
    }

    public bool Update(RoleDTO item)
    {
        throw new NotImplementedException();
    }
}
