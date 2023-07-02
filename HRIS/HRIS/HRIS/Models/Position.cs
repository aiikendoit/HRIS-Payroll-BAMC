﻿using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Position
{
    public int PkPosition { get; set; }

    public string? FkDepartment { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    /// <summary>
    /// getdate()
    /// </summary>
    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual ICollection<SystemUser> SystemUsers { get; set; } = new List<SystemUser>();

    public virtual Workassignment? Workassignment { get; set; }
}
