using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Wagefactor
{
    public int PkWagefactor { get; set; }

    public int? Amount { get; set; }

    public string? Remarks { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }
}
