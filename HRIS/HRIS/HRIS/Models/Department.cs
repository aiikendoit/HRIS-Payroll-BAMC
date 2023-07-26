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

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();

    public virtual ICollection<SystemUser> SystemUsers { get; set; } = new List<SystemUser>();

    public virtual ICollection<Workassignment> Workassignments { get; set; } = new List<Workassignment>();
}
