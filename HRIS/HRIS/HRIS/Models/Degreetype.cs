﻿using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Degreetype
{
    public int PkDegreetype { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Educationalattainment> Educationalattainments { get; set; } = new List<Educationalattainment>();
}
