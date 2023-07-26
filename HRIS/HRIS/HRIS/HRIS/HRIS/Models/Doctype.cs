using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Doctype
{
    public int PkDoctype { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsCertiificate { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Employeedocument> Employeedocuments { get; set; } = new List<Employeedocument>();
}
