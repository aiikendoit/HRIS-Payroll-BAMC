using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Department
{
    public int PkDepartment { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public int? FkSystemUser { get; set; }

    public string? Createdby { get; set; }

    public virtual ICollection<SystemUser> SystemUsers { get; set; } = new List<SystemUser>();

    public virtual Workassignment? Workassignment { get; set; }
}
