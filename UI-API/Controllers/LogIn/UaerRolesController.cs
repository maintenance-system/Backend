using BL.DTO.LogIn;
using BL.Interfaces;
using BL.Interfaces.LogIn;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI_API.Controllers.LogIn;

public class UaerRolesController : BaseController
{
    IUserRoleService userRoleService;
    public UaerRolesController(IUserRoleService userRoleService)
    {
        this.userRoleService = userRoleService;
    }

    [HttpGet]
    public async Task<List<UserRoleDTO>> GetAllAsync()
    {
        return await userRoleService.GetAllAsync();
    }

    [HttpPost]
    public async Task<int> Post(UserRoleDTO role)
    {
        return await userRoleService.CreateAsync(role);
    }

    [HttpDelete("{id}")]
    public async Task<bool> Delete(int id)
    {
        return await userRoleService.DeleteAsync(id);
    }
}

