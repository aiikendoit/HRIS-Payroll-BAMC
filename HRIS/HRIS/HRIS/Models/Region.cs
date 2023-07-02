using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Region
{
    public int PkRegion { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }
}
