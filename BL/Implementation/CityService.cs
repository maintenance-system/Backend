using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.DTO;
using DAL.DataObjects;
using DAL.Interfaces;
using BL.Interfaces;

namespace BL.Implementation;

public class CityService : ICityService
{
    ICityRepository cityRepository;
    public CityService(ICityRepository cityRepository)
    {
        this.cityRepository = cityRepository;
    }
    public int Creat(CityDTO item)
    {
        throw new NotImplementedException();
    }

    public bool Delete(CityDTO item)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CityDTO>> GetAllAsync()
    {
        List<City> cities = await cityRepository.GetAllAsync();
        List<CityDTO> citiesDtos = new();
        //todo: auto mapper
        foreach (var item in cities)
        {
            citiesDtos.Add(new CityDTO()
            {
                Id = item.Id,
                NameCity = item.NameCity
            });
        }
        return citiesDtos;
    }

    public bool Update(CityDTO item)
    {
        throw new NotImplementedException();
    }

}
