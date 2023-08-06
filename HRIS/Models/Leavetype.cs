using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Leavetype
{
    public int PkLeavetype { get; set; }

    public string? Description { get; set; }

    public bool IsPaid { get; set; }

    public bool Isactive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual ICollection<Employeeleaverequest> Employeeleaverequests { get; set; } = new List<Employeeleaverequest>();

    public virtual ICollection<Leavessetting> Leavessettings { get; set; } = new List<Leavessetting>();
}
