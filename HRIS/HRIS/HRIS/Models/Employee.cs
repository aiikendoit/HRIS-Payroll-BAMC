﻿using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Employee
{
    public int PkEmployee { get; set; }

    public string? Idno { get; set; }

    public int? Rfid { get; set; }

    public string? Biometricno { get; set; }

    public string? Lastname { get; set; }

    public string? Firstname { get; set; }

    public string? Middlename { get; set; }

    public string? Suffix { get; set; }

    public string? Extensionname { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Gender { get; set; }

    public int? FkProvince { get; set; }

    public int? FkTowncity { get; set; }

    public int? FkBarangay { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public int? Zipcode { get; set; }

    public int? FkCivilstatus { get; set; }

    public int? FkReligion { get; set; }

    public string? Nationality { get; set; }

    public string? Bloodtype { get; set; }

    public string? Telephoneno { get; set; }

    public string? Cellno { get; set; }

    public string? Email { get; set; }

    public int? FkBankid { get; set; }

    public int? Accountno { get; set; }

    public string? Contactperson { get; set; }

    public string? Contactrelationship { get; set; }

    public string? Contactno { get; set; }

    public int? Sssno { get; set; }

    public int? Pagibigno { get; set; }

    public int? Phicno { get; set; }

    public int? Tinno { get; set; }

    public byte[]? ProfilePicture { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdby { get; set; }

    public int? FkSystemUser { get; set; }

    public virtual Educationalattainment? Educationalattainment { get; set; }

    public virtual Employeedependent? Employeedependent { get; set; }

    public virtual ICollection<Employeedisciplinary> Employeedisciplinaries { get; set; } = new List<Employeedisciplinary>();

    public virtual ICollection<Employeedocument> Employeedocuments { get; set; } = new List<Employeedocument>();

    public virtual ICollection<Employeeleaverequest> Employeeleaverequests { get; set; } = new List<Employeeleaverequest>();

    public virtual ICollection<Employeelicense> Employeelicenses { get; set; } = new List<Employeelicense>();

    public virtual ICollection<Employmentstatus> Employmentstatuses { get; set; } = new List<Employmentstatus>();

    public virtual Bank? FkBank { get; set; }

    public virtual Barangay? FkBarangayNavigation { get; set; }

    public virtual Civilstatus? FkCivilstatusNavigation { get; set; }

    public virtual Religion? FkReligionNavigation { get; set; }

    public virtual SystemUser? FkSystemUserNavigation { get; set; }

    public virtual Towncity? FkTowncityNavigation { get; set; }

    public virtual Province PkEmployeeNavigation { get; set; } = null!;

    public virtual Workassignment? Workassignment { get; set; }
}
