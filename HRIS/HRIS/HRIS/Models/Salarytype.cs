using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Salarytype
{
    public int PkSalarytype { get; set; }

    public int? FkEmployeetype { get; set; }

    public string? Description { get; set; }

    public int? IsAllowance { get; set; }

    public int? IsBasicPay { get; set; }

    public int? IsBonus { get; set; }

    public int? IsThirteenMonth { get; set; }

    public int? IsTaxable { get; set; }

    public int? IsCola { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createdby { get; set; }
}
