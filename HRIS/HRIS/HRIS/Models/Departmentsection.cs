using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Departmentsection
{
    public int PkDepartmentsection { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual Workassignment? Workassignment { get; set; }
}
