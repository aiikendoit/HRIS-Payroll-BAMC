using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Leavessetting
{
    public int PkLeavessettings { get; set; }

    public int? FkLeavetype { get; set; }

    public int? FkEmployee { get; set; }

    public int? Totaldays { get; set; }

    public DateTime? Effectivitydate { get; set; }

    public bool IsBaseYearofService { get; set; }

    public int? YearofService { get; set; }

    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual Employee? FkEmployeeNavigation { get; set; }

    public virtual Leavetype? FkLeavetypeNavigation { get; set; }
}
