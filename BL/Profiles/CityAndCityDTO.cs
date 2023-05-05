using AutoMapper;
using BL.DTO;
using DAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Profiles
{
    internal class CityAndCityDTO : Profile
    {
        public CityAndCityDTO()
        {
            CreateMap<City, CityDTO>()
                .ReverseMap();
        }
    }
}
