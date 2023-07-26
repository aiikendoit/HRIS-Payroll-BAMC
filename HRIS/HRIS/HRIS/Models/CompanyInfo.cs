using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class CompanyInfo
{
    public int PkCompanyInfo { get; set; }

    public string? Organizationname { get; set; }

    public string? Owner { get; set; }

    public string? Website { get; set; }

    public string? Emailaddress { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public int? FkProvince { get; set; }

    public int? FkTowncity { get; set; }

    public int? FkBarangay { get; set; }

    public int? FkZipcode { get; set; }

    public byte[]? Logo { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Craetedby { get; set; }

    public int? FkSystemuser { get; set; }
}
