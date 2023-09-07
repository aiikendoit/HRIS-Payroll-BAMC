using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Salarytype
{
    public int PkSalarytype { get; set; }

    public int? FkEmploymenttype { get; set; }

    public string? Description { get; set; }

    public bool IsAllowance { get; set; }

    public bool IsBasicPay { get; set; }

    public bool IsBonus { get; set; }

    public bool IsThirteenMonth { get; set; }

    public bool IsTaxable { get; set; }

    public bool IsPercentage { get; set; }

    public bool IsCola { get; set; }

    public bool IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual Employmenttype? FkEmploymenttypeNavigation { get; set; }

    public virtual SystemUser? FkSystemUserNavigation { get; set; }
}
