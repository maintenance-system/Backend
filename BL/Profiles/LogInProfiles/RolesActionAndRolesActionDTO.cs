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
                .ForMember(dest => dest.Actions,
                        opt => opt.MapFrom(src => src.ActionsNavigation.Url))
                .ForMember(dest => dest.Role,
                        opt => opt.MapFrom(src => src.Role.Role1))
                .ReverseMap();
        }
    }
}
