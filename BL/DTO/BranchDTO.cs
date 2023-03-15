﻿using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class BranchDTO
{
    public int Id { get; set; }

    public string Symbol { get; set; } = null!;

    public int AddressId { get; set; }

    public virtual AddressDTO Address { get; set; } = null!;
}