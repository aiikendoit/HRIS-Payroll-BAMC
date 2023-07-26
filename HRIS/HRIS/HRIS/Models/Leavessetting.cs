using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Leavessetting
{
    public int PkLeavessettings { get; set; }

    public int? FkLeavetype { get; set; }

    public int? FkEmploymenttype { get; set; }

    public int? Totaldays { get; set; }

    public int? IsBaseYearofService { get; set; }

    public int? YearofService { get; set; }

    public string? Remarks { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual Employmenttype? FkEmploymenttypeNavigation { get; set; }

    public virtual Leavetype? FkLeavetypeNavigation { get; set; }
}
