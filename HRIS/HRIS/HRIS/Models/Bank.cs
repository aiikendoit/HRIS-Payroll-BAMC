using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Bank
{
    public int PkBank { get; set; }

    public int? FkEmployee { get; set; }

    public string? Bankname { get; set; }

    public int? Bankno { get; set; }

    public string? Remarks { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
