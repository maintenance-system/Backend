using BL.DTO.LogIn;
using BL.Interfaces;
using BL.Interfaces.LogIn;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI_API.Controllers.LogIn;

public class RoleActionsController : BaseController
{
    IRoleActionsService roleActionService;
    public RoleActionsController(IRoleActionsService roleActionService)
    {
        this.roleActionService = roleActionService;
    }

    [HttpGet]
    public async Task<List<RolesActionDTO>> GetAllAsync()
    {
        return await roleActionService.GetAllAsync();
    }

    [HttpPost]
    public async Task<int> Post(RolesActionDTO roleAction)
    {
        return await roleActionService.CreateAsync(roleAction);
    }

    [HttpDelete("{id}")]
    public async Task<bool> Delete(int id)
    {
        return await roleActionService.DeleteAsync(id);
    }
}
