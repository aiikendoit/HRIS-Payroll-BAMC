using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Educationalattainment
{
    public int PkEducationalattainment { get; set; }

    public int? FkEducationallevel { get; set; }

    public int? FkEmployee { get; set; }

    public string? Schoolattended { get; set; }

    public DateTime Yeargraduated { get; set; }

    public string? Educationaldegree { get; set; }

    public int? FkDegreetype { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Degreetype? FkDegreetypeNavigation { get; set; }

    public virtual Educationallevel? FkEducationallevelNavigation { get; set; }

    public virtual Employee? FkEmployeeNavigation { get; set; }

    public virtual SystemUser? FkSystemUserNavigation { get; set; }
}
