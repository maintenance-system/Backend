using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class Worker
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int? AddressBranch { get; set; }

    public string? PasswordLogin { get; set; }

    public virtual Address? AddressBranchNavigation { get; set; }
}
