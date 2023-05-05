using AutoMapper;
using BL.DTO.LogIn;
using DAL.DataObjects.LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Profiles.LogInProfiles
{
    internal class RolesActionAndRolesActionDTO : Profile
    {
        public RolesActionAndRolesActionDTO()
        {
            CreateMap<RolesAction, RolesActionDTO>()
                .ReverseMap();
        }
    }
}
