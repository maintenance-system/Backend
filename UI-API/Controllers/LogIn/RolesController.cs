using BL.DTO.LogIn;
using BL.Interfaces;
using BL.Interfaces.LogIn;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI_API.Controllers.logIn;

public class RolesController : BaseController
{
    IRoleService roleService;
    public RolesController(IRoleService roleService)
    {
        this.roleService = roleService;
    }

    [HttpGet]
    public async Task<List<RoleDTO>> GetAllAsync()
    {
        return await roleService.GetAllAsync();
    }

    [HttpPost]
    public async Task<int> Post(RoleDTO role)
    {
        return await roleService.CreateAsync(role);
    }

    [HttpDelete("{id}")]
    public async Task<bool> Delete(int id)
    {
        return await roleService.DeleteAsync(id);
    }
}
