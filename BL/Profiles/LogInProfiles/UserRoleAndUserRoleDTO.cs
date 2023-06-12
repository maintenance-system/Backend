using AutoMapper;
using BL.DTO.LogIn;
using DAL.DataObjects.LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Profiles.LogInProfiles;

internal class UserRoleAndUserRoleDTO : Profile
{
    public UserRoleAndUserRoleDTO()
    {
        CreateMap<UserRole, UserRoleDTO>()
            .ForMember(dest => dest.User,
                        opt => opt.MapFrom(src => src.User.Name))
            .ForMember(dest => dest.Role,
                        opt => opt.MapFrom(src => src.Role.Role1))
            .ReverseMap();
      /*      .ForMember(dest => dest.User.Name, opt => opt.MapFrom(src => src.User))
            .ForMember(dest => dest.Role.Role1, opt => opt.MapFrom(src => src.Role));*/


    }
}
