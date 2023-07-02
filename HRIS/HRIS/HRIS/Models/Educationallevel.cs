using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Educationallevel
{
    public int PkEducationallevel { get; set; }

    public string? Description { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual Educationalattainment? Educationalattainment { get; set; }
}
