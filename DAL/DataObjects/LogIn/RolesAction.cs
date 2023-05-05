using System;
using System.Collections.Generic;

namespace DAL.DataObjects.LogIn;

public partial class RolesAction
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int Actions { get; set; }

    public virtual Actions ActionsNavigation { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
