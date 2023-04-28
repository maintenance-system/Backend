using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class SafetyIssue
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<ConnectionSafety> ConnectionSafeties { get; } = new List<ConnectionSafety>();
}
