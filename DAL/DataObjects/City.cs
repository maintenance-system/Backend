using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class City
{
    public int Id { get; set; }

    public string NameCity { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();
}
