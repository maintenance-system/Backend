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

    [HttpGet("{userName}")]
    public async Task<ActionResult<RoleDTO>> GetRole(string userName)
    {

        List<RoleDTO>  roles = await GetRoleByName(userName);
        return Ok(roles);
    }

    [HttpPost]
    public async Task<int> Post(UserRoleDTO role) =>
        await userRoleService.CreateAsync(role);

/*    [HttpPost("{userName}/{role}")]
    public async Task<int> Post(string userName, string role)
    {
        string password = Request.Headers["Authorization"];
        var roleUser = new UserRoleDTO() { Role= role, User= userName };
        return await userRoleService.CreateAsync(roleUser, password);
    }*/

    [HttpDelete("{id}")]
    public async Task<bool> Delete(int id) =>
        await userRoleService.DeleteAsync(id);
    
    private async Task<List<RoleDTO>> GetRoleByName(string name)
    {
        return await userRoleService.GetRoleByName(name);
    }
}

