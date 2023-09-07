using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Employmentstatus
{
    public int PkEmployment { get; set; }

    public int? FkEmploymenttype { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Remarks { get; set; }

    public int? FkEmployee { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Employee? FkEmployeeNavigation { get; set; }

    public virtual Employmenttype? FkEmploymenttypeNavigation { get; set; }
}
