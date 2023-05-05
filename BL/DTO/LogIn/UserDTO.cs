using System;
using System.Collections.Generic;

namespace BL.DTO.LogIn;

public partial class UserDTO
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    //public virtual ICollection<UserRoleDTO> UserRoles { get; } = new List<UserRoleDTO>();
}
