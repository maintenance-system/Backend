using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class City
{
    public int Id { get; set; }

    public string NameCity { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Handyman> Handymen { get; set; } = new List<Handyman>();
}
