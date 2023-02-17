using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class Neighborhood
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();
}
