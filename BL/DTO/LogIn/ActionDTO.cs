using System;
using System.Collections.Generic;

namespace BL.DTO.LogIn;

public partial class ActionDTO
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string Url { get; set; } = null!;

   // public virtual ICollection<RolesActionDTO> RolesActions { get; } = new List<RolesActionDTO>();
}
