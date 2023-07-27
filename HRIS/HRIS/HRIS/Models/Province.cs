using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Province
{
    public int PkProvince { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkRegion { get; set; }

<<<<<<< HEAD
=======
    public virtual ICollection<CompanyInfo> CompanyInfos { get; set; } = new List<CompanyInfo>();

>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
