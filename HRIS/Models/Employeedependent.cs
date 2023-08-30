using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Employeedependent
{
    public int PkEmployeedependents { get; set; }

    public int? FkEmployee { get; set; }

    public int? FkRelationship { get; set; }

    public string? Lastname { get; set; }

    public string? Firstname { get; set; }

    public string? Middlename { get; set; }

    public string? Suffix { get; set; }

    public DateTime? Birthdate { get; set; }

    public int? FkCivilstatus { get; set; }

    public int? Contactno { get; set; }

    public byte[]? Address { get; set; }

    public bool? IsQualifiedDependent { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual Civilstatus? FkCivilstatusNavigation { get; set; }

    public virtual Employee PkEmployeedependentsNavigation { get; set; } = null!;
}
