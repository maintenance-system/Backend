using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class AddressDTO
{
    public int Id { get; set; }

    public int CityId { get; set; }

    public int? NeighborhoodId { get; set; }

    public string Street { get; set; } = null!;

    public string? Descreption { get; set; }

    public virtual ICollection<BranchDTO> Branches { get; } = new List<BranchDTO>();

    public virtual CityDTO City { get; set; } = null!;

    public virtual NeighborhoodDTO? Neighborhood { get; set; }
}
