using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class WorkerDTO
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; }

    public string? AddressBranch { get; set; }

    public string PasswordLogin { get; set; } = null!;

    //public virtual AddressDTO? AddressBranchNavigation { get; set; }
}
