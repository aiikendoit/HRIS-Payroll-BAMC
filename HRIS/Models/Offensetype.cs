using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Offensetype
{
    public int PkOffensetype { get; set; }

    public string? Description { get; set; }

    public int Severity { get; set; }

    public bool IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }
}
