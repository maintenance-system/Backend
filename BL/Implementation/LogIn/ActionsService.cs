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

internal class ActionsService : IActionsService
{
    IActionsRepository actionRepository;
    IMapper mapper;
    public ActionsService(IActionsRepository actionRepository, IMapper mapper)
    {
        this.actionRepository = actionRepository;
        this.mapper = mapper;
    }
    public async Task<int> CreateAsync(ActionDTO item)
    {
        Actions action = mapper.Map<Actions>(item);
        return await actionRepository.CreateAsync(action);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await actionRepository.DeleteAsync(id);
    }

    public async Task<List<ActionDTO>> GetAllAsync()
    {
        List<Actions> actions = await actionRepository.GetAllAsync();
        List<ActionDTO> actionsDtos = mapper.Map<List<ActionDTO>>(actions);

        return actionsDtos;
    }

    public bool Update(ActionDTO item)
    {
        throw new NotImplementedException();
    }
}
