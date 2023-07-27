using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Zipcode
{
    public int PkZipcode { get; set; }

    public int? Zipcode1 { get; set; }

    public int? FkTowncity { get; set; }

    public string? Areaname { get; set; }

    public bool? Isactive { get; set; }

    public byte[]? Description { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdate { get; set; }

<<<<<<< HEAD
=======
    public virtual ICollection<CompanyInfo> CompanyInfos { get; set; } = new List<CompanyInfo>();

>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
