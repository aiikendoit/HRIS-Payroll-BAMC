using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Employeeleaverequest
{
    public int PkEmployeeleave { get; set; }

    public int? FkEmployee { get; set; }

    public int? FkLeavetype { get; set; }

    public int? FkLeaveavailmenttype { get; set; }

    public int? FkLeavenoticetype { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public int? Numberofdaysleave { get; set; }

    public bool? Iscancel { get; set; }

    public DateTime? Canceldate { get; set; }

    public int? Cancelby { get; set; }

    public bool? Isapproved { get; set; }

    public int? Approvedby { get; set; }

    public DateTime? Approveddate { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Remarks { get; set; }

    public bool? Isvoid { get; set; }

    public DateTime? Voideddate { get; set; }

    public int? Voidedby { get; set; }

    public byte[]? Intentletter { get; set; }

    public virtual Employee? FkEmployeeNavigation { get; set; }

    public virtual Leavenoticetype? FkLeavenoticetypeNavigation { get; set; }

    public virtual Leavetype? FkLeavetypeNavigation { get; set; }
}
