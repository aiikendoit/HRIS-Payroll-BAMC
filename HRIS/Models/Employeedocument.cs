using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Employeedocument
{
    public int PkEmployeedocument { get; set; }

    public int? FkEmployee { get; set; }

    public int? FkDoctype { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public byte[]? EmployeeDocs { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual Doctype? FkDoctypeNavigation { get; set; }

    public virtual Employee? FkEmployeeNavigation { get; set; }
}
