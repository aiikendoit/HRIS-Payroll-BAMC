using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Educationalattainment
{
    public int PkEducationalattainment { get; set; }

    public int? FkEducationallevel { get; set; }

    public int? FkEmployee { get; set; }

    public DateTime? Schoolattended { get; set; }

    public string? Yeargraduated { get; set; }

    public string? Educationaldegree { get; set; }

    public int? FkDegreetype { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual Degreetype? FkDegreetypeNavigation { get; set; }

    public virtual Employee PkEducationalattainment1 { get; set; } = null!;

    public virtual Educationallevel PkEducationalattainmentNavigation { get; set; } = null!;
}
