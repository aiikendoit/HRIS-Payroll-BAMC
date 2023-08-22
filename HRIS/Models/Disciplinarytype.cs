using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Disciplinarytype
{
    public int PkDisciplinarytype { get; set; }

    public string? Disciplinarytypename { get; set; }

    public string? Disciplinarydescription { get; set; }

    public bool IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual ICollection<Employeedisciplinary> Employeedisciplinaries { get; set; } = new List<Employeedisciplinary>();
}
