using BL.DTO.LogIn;
using BL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI_API.Controllers
{
    public class UserController : BaseController
    {
        IUserService userService;
        public UserController(IUserService cityService)
        {
            this.userService = cityService;
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
    }
}
