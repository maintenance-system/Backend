﻿using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class NeighborhoodDTO
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AddressDTO> Addresses { get; } = new List<AddressDTO>();
}