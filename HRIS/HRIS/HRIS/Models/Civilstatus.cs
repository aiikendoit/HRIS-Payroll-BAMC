using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Civilstatus
{
    public int PkCivilstatus { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual ICollection<Employeedependent> Employeedependents { get; set; } = new List<Employeedependent>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
