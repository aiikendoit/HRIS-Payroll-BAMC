using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class SystemUser
{
    public int PkSystemUser { get; set; }

    public int? FkDepartment { get; set; }

    public int? FkPosition { get; set; }

    public int? FkSystemUserGroup { get; set; }

    public string? Usercode { get; set; }

    public string? Userpass { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Logdate { get; set; }

    public virtual ICollection<BankName> BankNames { get; set; } = new List<BankName>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Department? FkDepartmentNavigation { get; set; }

    public virtual Position? FkPositionNavigation { get; set; }

    public virtual ICollection<Nationality> Nationalities { get; set; } = new List<Nationality>();

    public virtual ICollection<Religion> Religions { get; set; } = new List<Religion>();

    public virtual ICollection<Salarytype> Salarytypes { get; set; } = new List<Salarytype>();

    public virtual ICollection<Workassignment> Workassignments { get; set; } = new List<Workassignment>();
}
