using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class HealthIssue
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<ConnectionHealth> ConnectionHealths { get; } = new List<ConnectionHealth>();
}
