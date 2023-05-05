using System;
using System.Collections.Generic;

namespace BL.DTO.LogIn;

public partial class UserRoleDTO
{
    public int Id { get; set; }

    public string UserId { get; set; }

    public string RoleId { get; set; }

  /*  public virtual RoleDTO Role { get; set; } = null!;

    public virtual UserDTO User { get; set; } = null!;*/
}
