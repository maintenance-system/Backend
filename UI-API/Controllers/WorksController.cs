using Microsoft.AspNetCore.Mvc;
using BL.Interfaces;
using BL.DTO;

namespace UI_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class WorksController : ControllerBase
    {
        ICityService cityService;
        public WorksController(ICityService cityService)
        {
            this.cityService = cityService;
        }

        [HttpGet]
        public async Task<List<CityDTO>> GetAllAsync()
        {
            return await cityService.GetAllAsync();
        }
    }
}
