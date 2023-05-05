using System;
using System.Collections.Generic;

namespace BL.DTO.LogIn;

public partial class RoleDTO
{
    public int Id { get; set; }

    public string Role1 { get; set; } = null!;

    //public virtual ICollection<RolesActionDTO> RolesActions { get; } = new List<RolesActionDTO>();

    //public virtual ICollection<UserRoleDTO> UserRoles { get; } = new List<UserRoleDTO>();
}
