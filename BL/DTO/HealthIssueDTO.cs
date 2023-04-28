using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class HealthIssueDTO
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

   // public virtual ICollection<ConnectionHealthDTO> ConnectionHealths { get; } = new List<ConnectionHealthDTO>();
}
