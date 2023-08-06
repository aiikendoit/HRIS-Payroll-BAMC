using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Leavenoticetype
{
    public int PkLeavenoticetype { get; set; }

    public string? Description { get; set; }

    public bool Isactive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual ICollection<Employeeleaverequest> Employeeleaverequests { get; set; } = new List<Employeeleaverequest>();
}
