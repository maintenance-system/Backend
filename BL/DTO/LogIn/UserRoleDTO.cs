using System;
using System.Collections.Generic;

namespace BL.DTO.LogIn;

public partial class UserRoleDTO
{
    public int Id { get; set; }

    public string User { get; set; }

    public string Role { get; set; }

    //public virtual RoleDTO Role { get; set; } = null!;

    //public virtual UserDTO User { get; set; } = null!;
}
