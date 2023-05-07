using System;
using System.Collections.Generic;

namespace BL.DTO.LogIn;

public partial class RolesActionDTO
{
    public int Id { get; set; }

    public string Role { get; set; }

    public string Actions { get; set; }

    //public virtual ActionDTO ActionsNavigation { get; set; } = null!;

    //public virtual RoleDTO Role { get; set; } = null!;
}
