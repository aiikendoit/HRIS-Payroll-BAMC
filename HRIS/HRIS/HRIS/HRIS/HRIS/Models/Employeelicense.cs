﻿using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Employeelicense
{
    public int PkEmployeelicense { get; set; }

    public int? FkEmployee { get; set; }

    public int? FkLicensetype { get; set; }

    public string? Licensenumber { get; set; }

    public string? Expirydate { get; set; }

    public string? Remarks { get; set; }

    public DateTime? Createddate { get; set; }

    public int? Createby { get; set; }

    public virtual Employee? FkEmployeeNavigation { get; set; }

    public virtual Licensetype? FkLicensetypeNavigation { get; set; }
}