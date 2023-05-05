using System;
using System.Collections.Generic;

namespace DAL.DataObjects.LogIn;

public partial class Role
{
    public int Id { get; set; }

    public string Role1 { get; set; } = null!;

    public virtual ICollection<RolesAction> RolesActions { get; } = new List<RolesAction>();

    public virtual ICollection<UserRole> UserRoles { get; } = new List<UserRole>();
}
