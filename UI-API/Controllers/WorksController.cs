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
        [HttpGet("id")]
       
        public async Task<CityDTO>? Get(int id)
        {

            var result = CityDTO.List.Where(p => p.Id == id).FirstOrDefault();
            return await result;
        }
        [HttpPost]
        public int Create(Product product)
        {
            int maxId = Products.ProductList.Max(p => p.Id);
            product.Id = maxId + 1;
            Products.ProductList.Add(product);
            return product.Id;
        }
    }
}
