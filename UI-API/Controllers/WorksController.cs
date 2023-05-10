using Microsoft.AspNetCore.Mvc;
using BL.Interfaces;
using BL.DTO;

namespace UI_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class WorksController : WorksBaceController
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


        //[HttpGet("id")]
       
      /*  public async Task<CityDTO>? Get(int id)
        {
           *//* var result = new CityDTO();
          //  var result = CityDTO.List.Where(p => p.Id == id).FirstOrDefault();
            return await result;*//*


        }*/
        [HttpPost]
        public async Task<int> Post(CityDTO city)
        {
            return await cityService.CreateAsync(city);
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await cityService.DeleteAsync(id);
        }


    }
}
