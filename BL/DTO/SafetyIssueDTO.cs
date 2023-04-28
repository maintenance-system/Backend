using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class SafetyIssueDTO
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

   // public virtual ICollection<ConnectionSafetyDTO> ConnectionSafeties { get; } = new List<ConnectionSafetyDTO>();
}
