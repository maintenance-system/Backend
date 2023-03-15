using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class CityDTO
{
    public int Id { get; set; }

    public string NameCity { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();
}
