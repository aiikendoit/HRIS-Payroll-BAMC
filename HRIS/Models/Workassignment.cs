using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Workassignment
{
    public int PkWorkassignment { get; set; }

    public int? FkEmployee { get; set; }

    public int? FkDepartment { get; set; }

    public int? FkPosition { get; set; }

    public byte[]? Jobdescription { get; set; }

    public string? FileExtension { get; set; }

    public string? Filename { get; set; }

    public bool IsManager { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Department? FkDepartmentNavigation { get; set; }

    public virtual Employee? FkEmployeeNavigation { get; set; }

    public virtual Position? FkPositionNavigation { get; set; }

    public virtual SystemUser? FkSystemUserNavigation { get; set; }
}
