using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Employmenttype
{
    public int PkEmploymenttype { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public virtual ICollection<Employmentstatus> Employmentstatuses { get; set; } = new List<Employmentstatus>();

    public virtual ICollection<Leavessetting> Leavessettings { get; set; } = new List<Leavessetting>();
}
