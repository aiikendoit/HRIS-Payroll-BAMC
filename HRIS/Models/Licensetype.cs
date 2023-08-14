﻿using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Licensetype
{
    public int PkLicensetype { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual ICollection<Employeelicense> Employeelicenses { get; set; } = new List<Employeelicense>();
}