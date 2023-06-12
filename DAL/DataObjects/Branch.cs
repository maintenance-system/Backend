using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class Branch
{
    public int Id { get; set; }

    public string Symbol { get; set; } = null!;

    public int AddressId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<ConnectionHealth> ConnectionHealths { get; set; } = new List<ConnectionHealth>();

    public virtual ICollection<ConnectionSafety> ConnectionSafeties { get; set; } = new List<ConnectionSafety>();
}
