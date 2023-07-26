using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Towncity
{
    public int PkTowncity { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int FkProvince { get; set; }

    public virtual ICollection<CompanyInfo> CompanyInfos { get; set; } = new List<CompanyInfo>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
