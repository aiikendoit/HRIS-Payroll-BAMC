using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Employmentstatus
{
    public int PkEmployment { get; set; }

    public int? FkEmploymenttype { get; set; }

    public DateTime? Startdate { get; set; }

    public string? Enddate { get; set; }

    public string? Remarks { get; set; }

    public int? FkEmployee { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual Employee? FkEmployeeNavigation { get; set; }

    public virtual Employmenttype? FkEmploymenttypeNavigation { get; set; }
}
