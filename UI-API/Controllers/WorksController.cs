using Microsoft.AspNetCore.Mvc;
using DAL.DataObjects;
using DAL.Implementation;

namespace UI_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class WorksController : ControllerBase
    {
        [HttpGet]
        public List<City> GetAll()
        {
            CityRepository cityList = new();
            var x= cityList.Read();
            return x;
        }
    }
}
