using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class Address
{
    public int Id { get; set; }

    public int CityId { get; set; }

    public int? NeighborhoodId { get; set; }

    public string Street { get; set; } = null!;

    public string? Descreption { get; set; }

    public virtual ICollection<Branch> Branches { get; } = new List<Branch>();

    public virtual City City { get; set; } = null!;

    public virtual Neighborhood? Neighborhood { get; set; }
}
