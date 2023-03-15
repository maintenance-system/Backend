using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class CityBL
{
    public int Id { get; set; }

    public string NameCity { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();
}
