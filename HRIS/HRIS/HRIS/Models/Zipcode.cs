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

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
