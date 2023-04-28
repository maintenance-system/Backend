using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class ConnectionSafety
{
    public int Id { get; set; }

    public DateTime RegistrationDate { get; set; }

    public int IssuesId { get; set; }

    public int BranchId { get; set; }

    public string? Description { get; set; }

    public bool? Selected { get; set; }

    public bool? Completed { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual SafetyIssue Issues { get; set; } = null!;
}
