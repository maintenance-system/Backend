using System;
using System.Collections.Generic;

namespace BL.BlObjects;

public partial class Branch
{
    public int Id { get; set; }

    public string Symbol { get; set; } = null!;

    public int AddressId { get; set; }

    public virtual Address Address { get; set; } = null!;
}
