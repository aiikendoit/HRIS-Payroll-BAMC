using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class BankName
{
    public int PkBankName { get; set; }

    public string? Bankname1 { get; set; }

    public bool Isactive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual SystemUser? FkSystemUserNavigation { get; set; }
}
