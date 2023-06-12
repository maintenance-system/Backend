using BL.DTO.LogIn;
using BL.Interfaces;
using BL.Interfaces.LogIn;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI_API.Controllers.Login;

public class UserController : BaseController
{
    IUserService userService;
    public UserController(IUserService cityService)
    {
        this.userService = cityService;
    }

    [HttpGet("{userName}")]
    public IActionResult GetUser(string userName)
    {
        string password = Request.Headers["Authorization"];


        bool isAuthenticated = CheckCredentials(userName, password);
        return Ok(isAuthenticated);
    }
    private bool CheckCredentials(string userName, string password)
    {
        return EqualsByPassword(password) == userName;
    }

    [HttpGet]
    public async Task<List<UserDTO>> GetAllAsync()
    {
        return await userService.GetAllAsync();
    }

    [HttpPost]
    public async Task<int> Post(UserDTO user)
    {
        return await userService.CreateAsync(user);
    }

    [HttpDelete("{id}")]
    public async Task<bool> Delete(int id)
    {
        return await userService.DeleteAsync(id);
    }

    private string EqualsByPassword(string password)
    {
        return userService.EqualsByPassword(password);
    }
}
