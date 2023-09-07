using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Wagefactor
{
    public int PkWagefactor { get; set; }

    public string? Description { get; set; }

    public decimal? Amount { get; set; }

    public bool IsActive { get; set; }

    /// <summary>
    /// getdate()
    /// </summary>
    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }
}
