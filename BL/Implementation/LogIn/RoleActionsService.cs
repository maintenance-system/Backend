using AutoMapper;
using BL.DTO;
using BL.DTO.LogIn;
using BL.Interfaces.LogIn;
using DAL.DataObjects;
using DAL.DataObjects.LogIn;
using DAL.Implementation;
using DAL.Interfaces.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation.LogIn;

internal class RoleActionsService : IRoleActionsService
{
    IRoleActionRepository roleActionRepository;
    IMapper mapper;

    public RoleActionsService(IRoleActionRepository roleActionRepository, IMapper mapper)
    {
        this.roleActionRepository = roleActionRepository;
        this.mapper = mapper;
    }

    public async Task<int> CreateAsync(RolesActionDTO item)
    {
        RolesAction action = mapper.Map<RolesAction>(item);
        return await roleActionRepository.CreateAsync(action);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await roleActionRepository.DeleteAsync(id);
    }

    public async Task<List<RolesActionDTO>> GetAllAsync()
    {
        List<RolesAction> roleActions = await roleActionRepository.GetAllAsync();
        List<RolesActionDTO> roleActionsDtos = mapper.Map<List<RolesActionDTO>>(roleActions);

        return roleActionsDtos;
    }

    public bool Update(RolesActionDTO item)
    {
        throw new NotImplementedException();
    }
}
