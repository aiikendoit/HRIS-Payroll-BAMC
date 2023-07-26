using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Educationallevel
{
    public int PkEducationallevel { get; set; }

    public string? Description { get; set; }

    public bool Isactive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual Educationalattainment? Educationalattainment { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Educationallevel? FkSystemUserNavigation { get; set; }

    public virtual ICollection<Educationallevel> InverseFkSystemUserNavigation { get; set; } = new List<Educationallevel>();
}
