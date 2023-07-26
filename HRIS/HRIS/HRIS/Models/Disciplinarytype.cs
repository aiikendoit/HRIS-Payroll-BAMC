using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Disciplinarytype
{
    public int PkDisciplinarytype { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Employeedisciplinary> Employeedisciplinaries { get; set; } = new List<Employeedisciplinary>();
}
