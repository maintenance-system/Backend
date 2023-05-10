using BL.DTO.LogIn;
using BL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI_API.Controllers
{
    public class ActionsController : BaseController
    {
        IActionsService actionService;
        public ActionsController(IActionsService actionService)
        {
            this.actionService = actionService;
        }

        [HttpGet]
        public async Task<List<ActionDTO>> GetAllAsync()
        {
            return await actionService.GetAllAsync();
        }

        [HttpPost]
        public async Task<int> Post(ActionDTO action)
        {
            return await actionService.CreateAsync(action);
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await actionService.DeleteAsync(id);
        }
    }
}
