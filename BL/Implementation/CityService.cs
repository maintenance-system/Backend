using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.DTO;
using DAL.DataObjects;
using DAL.Interfaces;
using BL.Interfaces;
using AutoMapper;

namespace BL.Implementation;

public class CityService : ICityService
{
    ICityRepository cityRepository;
    IMapper mapper;
    public CityService(ICityRepository cityRepository, IMapper mapper)
    {
        this.cityRepository = cityRepository;
        this.mapper = mapper;
    }
    public async Task<int> CreateAsync(CityDTO item)
    {
        City city = mapper.Map<City>(item);
        return await cityRepository.CreateAsync(city);
    }

    public bool Delete(CityDTO item)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CityDTO>> GetAllAsync()
    {
        List<City> cities = await cityRepository.GetAllAsync();
        List<CityDTO> citiesDtos = mapper.Map<List<CityDTO>>(cities);
        
        return citiesDtos;
    }

    public bool Update(CityDTO item)
    {
        throw new NotImplementedException();
    }

}
