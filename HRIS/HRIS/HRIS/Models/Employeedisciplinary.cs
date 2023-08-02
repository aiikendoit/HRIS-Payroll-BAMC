using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Employeedisciplinary
{
    public int PkEmployeedisciplinary { get; set; }

    public int? FkEmployee { get; set; }

    public int? FkOffensetype { get; set; }

    public int? FkDisciplinarytype { get; set; }

    public string? Description { get; set; }

    public DateTime? Datestart { get; set; }

    public DateTime? Dateend { get; set; }

    public byte[]? File { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createby { get; set; }

    public virtual Employee? FkEmployeeNavigation { get; set; }

    public virtual Offensetype? FkOffensetypeNavigation { get; set; }
}
