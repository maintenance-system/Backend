using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class AddressDTO
{
    public int Id { get; set; }

    public string City { get; set; }

    public string? Neighborhood { get; set; }

    public string Street { get; set; } = null!;

    public string? Descreption { get; set; }

  //  public virtual ICollection<BranchDTO> Branches { get; } = new List<BranchDTO>();

   //public virtual CityDTO City { get; set; } = null!;

}
