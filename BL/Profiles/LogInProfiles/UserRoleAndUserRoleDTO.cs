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
    internal class UserRoleAndUserRoleDTO : Profile
    {
        public UserRoleAndUserRoleDTO()
        {
            CreateMap<UserRole, UserRoleDTO>()
               .ReverseMap();
        }
    }
}
