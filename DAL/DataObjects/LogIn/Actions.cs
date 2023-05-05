using System;
using System.Collections.Generic;

namespace DAL.DataObjects.LogIn;

public partial class Actions
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string Url { get; set; } = null!;

    public virtual ICollection<RolesAction> RolesActions { get; } = new List<RolesAction>();
}
