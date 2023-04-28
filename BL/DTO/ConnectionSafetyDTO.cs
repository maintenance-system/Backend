using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class ConnectionSafetyDTO
{
    public int Id { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string IssuesId { get; set; }

    public string BranchId { get; set; }

    public string? Description { get; set; }

    public bool? Selected { get; set; }

    public bool? Completed { get; set; }

    //public virtual BranchDTO Branch { get; set; } = null!;

    //public virtual SafetyIssueDTO Issues { get; set; } = null!;
}
