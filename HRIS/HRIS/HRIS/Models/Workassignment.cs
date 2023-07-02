using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Workassignment
{
    public int PkWorkassignment { get; set; }

    public int? FkEmployee { get; set; }

    public int? FkDepartment { get; set; }

    public int? FkDepartmentsection { get; set; }

    public int? FkPosition { get; set; }

    public string? Jobdescription { get; set; }

    public string? Responsibilities { get; set; }

    public string? Jobscope { get; set; }

    public bool? IsManager { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Remarks { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createby { get; set; }

    public virtual Departmentsection PkWorkassignment1 { get; set; } = null!;

    public virtual Employee PkWorkassignment2 { get; set; } = null!;

    public virtual Position PkWorkassignment3 { get; set; } = null!;

    public virtual Department PkWorkassignmentNavigation { get; set; } = null!;
}
