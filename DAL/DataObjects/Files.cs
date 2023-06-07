using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class Files
{
    public int Id { get; set; }

    public string? NameFile { get; set; }

    public string UrlFile { get; set; } = null!;

    public string PathFile { get; set; } = null!;

    public string Status { get; set; } = null!;
}
