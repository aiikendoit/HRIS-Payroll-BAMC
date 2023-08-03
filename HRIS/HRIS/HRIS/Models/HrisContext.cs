using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Models;

public partial class HrisContext : DbContext
{
    public HrisContext()
    {
    }

    public HrisContext(DbContextOptions<HrisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BankName> BankNames { get; set; }

    public virtual DbSet<Barangay> Barangays { get; set; }

    public virtual DbSet<Checkinout> Checkinouts { get; set; }

    public virtual DbSet<Civilstatus> Civilstatuses { get; set; }

    public virtual DbSet<CompanyInfo> CompanyInfos { get; set; }

    public virtual DbSet<Degreetype> Degreetypes { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Departmentsection> Departmentsections { get; set; }

    public virtual DbSet<Disciplinarytype> Disciplinarytypes { get; set; }

    public virtual DbSet<Doctype> Doctypes { get; set; }

    public virtual DbSet<Educationalattainment> Educationalattainments { get; set; }

    public virtual DbSet<Educationallevel> Educationallevels { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employeedependent> Employeedependents { get; set; }

    public virtual DbSet<Employeedisciplinary> Employeedisciplinaries { get; set; }

    public virtual DbSet<Employeedocument> Employeedocuments { get; set; }

    public virtual DbSet<Employeeleaverequest> Employeeleaverequests { get; set; }

    public virtual DbSet<Employeelicense> Employeelicenses { get; set; }

    public virtual DbSet<Employmentstatus> Employmentstatuses { get; set; }

    public virtual DbSet<Employmenttype> Employmenttypes { get; set; }

    public virtual DbSet<Leavenoticetype> Leavenoticetypes { get; set; }

    public virtual DbSet<Leavessetting> Leavessettings { get; set; }

    public virtual DbSet<Leavetype> Leavetypes { get; set; }

    public virtual DbSet<Licensetype> Licensetypes { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<Offensetype> Offensetypes { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Relationship> Relationships { get; set; }

    public virtual DbSet<Religion> Religions { get; set; }

    public virtual DbSet<Salarytype> Salarytypes { get; set; }

    public virtual DbSet<SystemUser> SystemUsers { get; set; }

    public virtual DbSet<Towncity> Towncities { get; set; }

    public virtual DbSet<Wagefactor> Wagefactors { get; set; }

    public virtual DbSet<Workassignment> Workassignments { get; set; }

    public virtual DbSet<Zipcode> Zipcodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=webserver; initial catalog=hris; user id=sa; password=web2021; trustServerCertificate=true;")
                          .UseLazyLoadingProxies();
        }
    }
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Data Source=192.168.0.55; initial catalog=hris; user id=sa; password=web2021; trustServerCertificate=true; ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BankName>(entity =>
        {
            entity.HasKey(e => e.PkBankName).HasName("PK__bank__753BC28F25FDB77E");

            entity.ToTable("bankName", "Template");

            entity.Property(e => e.PkBankName).HasColumnName("PK_bankName");
            entity.Property(e => e.Bankname1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("bankname");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.Isactive).HasColumnName("isactive");

            entity.HasOne(d => d.FkSystemUserNavigation).WithMany(p => p.BankNames)
                .HasForeignKey(d => d.FkSystemUser)
                .HasConstraintName("FK_bank_systemuser");
        });

        modelBuilder.Entity<Barangay>(entity =>
        {
            entity.HasKey(e => e.PkBarangay).HasName("PK__barangay__E04CBB92BD2399C7");

            entity.ToTable("barangay", "Template");

            entity.Property(e => e.PkBarangay).HasColumnName("PK_barangay");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkTownCity).HasColumnName("FK_TownCity");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Checkinout>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHECKINOUT");

            entity.Property(e => e.Acno).HasColumnName("ACNO");
            entity.Property(e => e.Checktime)
                .HasColumnType("datetime")
                .HasColumnName("CHECKTIME");
            entity.Property(e => e.Checktype).HasColumnName("CHECKTYPE");
            entity.Property(e => e.Sensorid).HasColumnName("SENSORID");
            entity.Property(e => e.Serialno)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SERIALNO");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Verifycode).HasColumnName("VERIFYCODE");
        });

        modelBuilder.Entity<Civilstatus>(entity =>
        {
            entity.HasKey(e => e.PkCivilstatus).HasName("PK__civilsta__DCC6623DE502226A");

            entity.ToTable("civilstatus", "Template");

            entity.Property(e => e.PkCivilstatus).HasColumnName("PK_civilstatus");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<CompanyInfo>(entity =>
        {
            entity.HasKey(e => e.PkCompanyInfo);

            entity.ToTable("companyInfo", "HR");

            entity.Property(e => e.PkCompanyInfo).HasColumnName("PK_companyInfo");
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("address2");
            entity.Property(e => e.Address3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("address3");
            entity.Property(e => e.Craetedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Emailaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emailaddress");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.FkBarangay).HasColumnName("FK_barangay");
            entity.Property(e => e.FkProvince).HasColumnName("FK_province");
            entity.Property(e => e.FkSystemuser).HasColumnName("FK_systemuser");
            entity.Property(e => e.FkTowncity).HasColumnName("FK_towncity");
            entity.Property(e => e.FkZipcode).HasColumnName("FK_zipcode");
            entity.Property(e => e.Logo)
                .HasColumnType("image")
                .HasColumnName("logo");
            entity.Property(e => e.Organizationname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("organizationname");
            entity.Property(e => e.Owner)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("owner");
            entity.Property(e => e.Telephone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telephone");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("website");

            entity.HasOne(d => d.FkBarangayNavigation).WithMany(p => p.CompanyInfos)
                .HasForeignKey(d => d.FkBarangay)
                .HasConstraintName("FK_companyInfo_barangay");

            entity.HasOne(d => d.FkProvinceNavigation).WithMany(p => p.CompanyInfos)
                .HasForeignKey(d => d.FkProvince)
                .HasConstraintName("FK_companyInfo_province");

            entity.HasOne(d => d.FkTowncityNavigation).WithMany(p => p.CompanyInfos)
                .HasForeignKey(d => d.FkTowncity)
                .HasConstraintName("FK_companyInfo_towncity");

            entity.HasOne(d => d.FkZipcodeNavigation).WithMany(p => p.CompanyInfos)
                .HasForeignKey(d => d.FkZipcode)
                .HasConstraintName("FK_companyInfo_zipcode");
        });

        modelBuilder.Entity<Degreetype>(entity =>
        {
            entity.HasKey(e => e.PkDegreetype).HasName("PK__degreety__20FD5C174D65E568");

            entity.ToTable("degreetype", "Template");

            entity.Property(e => e.PkDegreetype).HasColumnName("PK_degreetype");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.PkDepartment).HasName("PK__departme__14159A99A93A91AB");

            entity.ToTable("department", "Template");

            entity.Property(e => e.PkDepartment).HasColumnName("PK_department");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Departmentsection>(entity =>
        {
            entity.HasKey(e => e.PkDepartmentsection).HasName("PK__departme__54B3E25C8D41998D");

            entity.ToTable("departmentsection", "Template");

            entity.Property(e => e.PkDepartmentsection)
                .ValueGeneratedNever()
                .HasColumnName("PK_departmentsection");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Disciplinarytype>(entity =>
        {
            entity.HasKey(e => e.PkDisciplinarytype).HasName("PK__discipli__590AA46E0F644162");

            entity.ToTable("disciplinarytype", "Template");

            entity.Property(e => e.PkDisciplinarytype).HasColumnName("PK_disciplinarytype");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Disciplinarydescription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("disciplinarydescription");
            entity.Property(e => e.Disciplinarytypename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("disciplinarytypename");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Doctype>(entity =>
        {
            entity.HasKey(e => e.PkDoctype).HasName("PK__doctype__55FF1B93A0235070");

            entity.ToTable("doctype", "Template");

            entity.Property(e => e.PkDoctype).HasColumnName("PK_doctype");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsCertiificate).HasColumnName("isCertiificate");
        });

        modelBuilder.Entity<Educationalattainment>(entity =>
        {
            entity.HasKey(e => e.PkEducationalattainment).HasName("PK__educatio__8718DE4E26D0976A");

            entity.ToTable("educationalattainment", "HR");

            entity.Property(e => e.PkEducationalattainment)
                .ValueGeneratedNever()
                .HasColumnName("PK_educationalattainment");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Educationaldegree)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("educationaldegree");
            entity.Property(e => e.FkDegreetype).HasColumnName("FK_degreetype");
            entity.Property(e => e.FkEducationallevel).HasColumnName("FK_educationallevel");
            entity.Property(e => e.FkEmployee).HasColumnName("FK_employee");
            entity.Property(e => e.Schoolattended)
                .HasColumnType("datetime")
                .HasColumnName("schoolattended");
            entity.Property(e => e.Yeargraduated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("yeargraduated");

            entity.HasOne(d => d.FkDegreetypeNavigation).WithMany(p => p.Educationalattainments)
                .HasForeignKey(d => d.FkDegreetype)
                .HasConstraintName("FK_educationalattainment_degreetype");

            entity.HasOne(d => d.PkEducationalattainmentNavigation).WithOne(p => p.Educationalattainment)
                .HasForeignKey<Educationalattainment>(d => d.PkEducationalattainment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_educationlevel");

            entity.HasOne(d => d.PkEducationalattainment1).WithOne(p => p.Educationalattainment)
                .HasForeignKey<Educationalattainment>(d => d.PkEducationalattainment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_employee");
        });

        modelBuilder.Entity<Educationallevel>(entity =>
        {
            entity.HasKey(e => e.PkEducationallevel).HasName("PK__educatio__C60E338487DF3BE0");

            entity.ToTable("educationallevel", "Template");

            entity.Property(e => e.PkEducationallevel).HasColumnName("PK_educationallevel");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.Isactive).HasColumnName("isactive");

            entity.HasOne(d => d.FkSystemUserNavigation).WithMany(p => p.InverseFkSystemUserNavigation)
                .HasForeignKey(d => d.FkSystemUser)
                .HasConstraintName("FK_educationallevel_systemUser");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.PkEmployee).HasName("PK__employee__99755A5C82A9845D");

            entity.ToTable("employee", "HR");

            entity.Property(e => e.PkEmployee).HasColumnName("PK_employee");
            entity.Property(e => e.Accountno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accountno");
            entity.Property(e => e.Address1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("address2");
            entity.Property(e => e.Address3)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("address3");
            entity.Property(e => e.Biometricno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("biometricno");
            entity.Property(e => e.Birthdate)
                .HasColumnType("date")
                .HasColumnName("birthdate");
            entity.Property(e => e.Bloodtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bloodtype");
            entity.Property(e => e.Cellno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cellno");
            entity.Property(e => e.Contactno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactno");
            entity.Property(e => e.Contactperson)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactperson");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Employeetype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("employeetype");
            entity.Property(e => e.Extensionname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("extensionname");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.FkBankName).HasColumnName("FK_bankName");
            entity.Property(e => e.FkBarangay).HasColumnName("FK_barangay");
            entity.Property(e => e.FkCivilstatus).HasColumnName("FK_civilstatus");
            entity.Property(e => e.FkEducationallevel).HasColumnName("FK_educationallevel");
            entity.Property(e => e.FkNationality).HasColumnName("FK_nationality");
            entity.Property(e => e.FkProvince).HasColumnName("FK_province");
            entity.Property(e => e.FkRelationship).HasColumnName("FK_relationship");
            entity.Property(e => e.FkReligion).HasColumnName("FK_religion");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.FkTowncity).HasColumnName("FK_towncity");
            entity.Property(e => e.FkZipcode).HasColumnName("FK_zipcode");
            entity.Property(e => e.Gender)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Idno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("idno");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Middlename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("middlename");
            entity.Property(e => e.Pagibigno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pagibigno");
            entity.Property(e => e.Phicno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phicno");
            entity.Property(e => e.ProfilePicture).HasColumnType("image");
            entity.Property(e => e.Rfid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("rfid");
            entity.Property(e => e.Sssno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sssno");
            entity.Property(e => e.Suffix)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("suffix");
            entity.Property(e => e.Telephoneno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telephoneno");
            entity.Property(e => e.Tinno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tinno");

            entity.HasOne(d => d.FkBankNameNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkBankName)
                .HasConstraintName("FK_bank");

            entity.HasOne(d => d.FkBarangayNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkBarangay)
                .HasConstraintName("FK_barangay");

            entity.HasOne(d => d.FkCivilstatusNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkCivilstatus)
                .HasConstraintName("FK_civilstatus");

            entity.HasOne(d => d.FkEducationallevelNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkEducationallevel)
                .HasConstraintName("FK_employee_educationallevel");

            entity.HasOne(d => d.FkNationalityNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkNationality)
                .HasConstraintName("FK_employee_nationality");

            entity.HasOne(d => d.FkProvinceNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkProvince)
                .HasConstraintName("FK_province");

            entity.HasOne(d => d.FkRelationshipNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkRelationship)
                .HasConstraintName("FK_employee_relationship");

            entity.HasOne(d => d.FkReligionNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkReligion)
                .HasConstraintName("FK_religion");

            entity.HasOne(d => d.FkSystemUserNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkSystemUser)
                .HasConstraintName("FK_systemuser_employee");

            entity.HasOne(d => d.FkTowncityNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkTowncity)
                .HasConstraintName("FK_towncity");

            entity.HasOne(d => d.FkZipcodeNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkZipcode)
                .HasConstraintName("FK_employee_zipcode");
        });

        modelBuilder.Entity<Employeedependent>(entity =>
        {
            entity.HasKey(e => e.PkEmployeedependents).HasName("PK__employee__EF69E6CAB4DEB879");

            entity.ToTable("employeedependents", "HR");

            entity.Property(e => e.PkEmployeedependents)
                .ValueGeneratedNever()
                .HasColumnName("PK_employeedependents");
            entity.Property(e => e.Birthdate)
                .HasColumnType("date")
                .HasColumnName("birthdate");
            entity.Property(e => e.Contactno).HasColumnName("contactno");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Firstname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.FkCivilstatus).HasColumnName("FK_civilstatus");
            entity.Property(e => e.FkEmployee).HasColumnName("FK_employee");
            entity.Property(e => e.FkRelationship).HasColumnName("FK_relationship");
            entity.Property(e => e.IsQualifiedDependent).HasColumnName("isQualifiedDependent");
            entity.Property(e => e.Lastname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Middlename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("middlename");
            entity.Property(e => e.Suffix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("suffix");

            entity.HasOne(d => d.FkCivilstatusNavigation).WithMany(p => p.Employeedependents)
                .HasForeignKey(d => d.FkCivilstatus)
                .HasConstraintName("FK_employeedependents_civilstatus");

            entity.HasOne(d => d.PkEmployeedependentsNavigation).WithOne(p => p.Employeedependent)
                .HasForeignKey<Employeedependent>(d => d.PkEmployeedependents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_employeedependents_employee");
        });

        modelBuilder.Entity<Employeedisciplinary>(entity =>
        {
            entity.HasKey(e => e.PkEmployeedisciplinary).HasName("PK__employee__800F3D242481DBEC");

            entity.ToTable("employeedisciplinary", "HR");

            entity.Property(e => e.PkEmployeedisciplinary)
                .ValueGeneratedNever()
                .HasColumnName("PK_employeedisciplinary");
            entity.Property(e => e.Createby).HasColumnName("createby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Dateend)
                .HasColumnType("datetime")
                .HasColumnName("dateend");
            entity.Property(e => e.Datestart)
                .HasColumnType("datetime")
                .HasColumnName("datestart");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.File)
                .HasMaxLength(1)
                .HasColumnName("file");
            entity.Property(e => e.FkDisciplinarytype).HasColumnName("FK_disciplinarytype");
            entity.Property(e => e.FkEmployee).HasColumnName("FK_employee");
            entity.Property(e => e.FkOffensetype).HasColumnName("FK_offensetype");

            entity.HasOne(d => d.FkEmployeeNavigation).WithMany(p => p.Employeedisciplinaries)
                .HasForeignKey(d => d.FkEmployee)
                .HasConstraintName("FK_employeedisciplinary_employee");

            entity.HasOne(d => d.FkOffensetypeNavigation).WithMany(p => p.Employeedisciplinaries)
                .HasForeignKey(d => d.FkOffensetype)
                .HasConstraintName("FK_employeedisciplinary_offensetype");
        });

        modelBuilder.Entity<Employeedocument>(entity =>
        {
            entity.HasKey(e => e.PkEmployeedocument).HasName("PK__employee__0C23C9EECDB8C61D");

            entity.ToTable("employeedocument", "HR");

            entity.Property(e => e.PkEmployeedocument)
                .ValueGeneratedNever()
                .HasColumnName("PK_employeedocument");
            entity.Property(e => e.Createby).HasColumnName("createby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.File)
                .HasColumnType("image")
                .HasColumnName("file");
            entity.Property(e => e.FkDoctype).HasColumnName("FK_doctype");
            entity.Property(e => e.FkEmployee).HasColumnName("FK_employee");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");

            entity.HasOne(d => d.FkDoctypeNavigation).WithMany(p => p.Employeedocuments)
                .HasForeignKey(d => d.FkDoctype)
                .HasConstraintName("FK_employeedocument_doctype");

            entity.HasOne(d => d.FkEmployeeNavigation).WithMany(p => p.Employeedocuments)
                .HasForeignKey(d => d.FkEmployee)
                .HasConstraintName("FK_employeedocument_employee");
        });

        modelBuilder.Entity<Employeeleaverequest>(entity =>
        {
            entity.HasKey(e => e.PkEmployeeleave).HasName("PK__Employee__9E0F75FDFFBE32B9");

            entity.ToTable("Employeeleaverequest", "HR");

            entity.Property(e => e.PkEmployeeleave)
                .ValueGeneratedNever()
                .HasColumnName("PK_Employeeleave");
            entity.Property(e => e.Approvedby).HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("datetime")
                .HasColumnName("approveddate");
            entity.Property(e => e.Cancelby).HasColumnName("cancelby");
            entity.Property(e => e.Canceldate)
                .HasColumnType("datetime")
                .HasColumnName("canceldate");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Enddate)
                .HasColumnType("date")
                .HasColumnName("enddate");
            entity.Property(e => e.FkEmployee).HasColumnName("FK_Employee");
            entity.Property(e => e.FkLeaveavailmenttype).HasColumnName("FK_leaveavailmenttype");
            entity.Property(e => e.FkLeavenoticetype).HasColumnName("FK_leavenoticetype");
            entity.Property(e => e.FkLeavetype).HasColumnName("FK_leavetype");
            entity.Property(e => e.Intentletter).HasColumnName("intentletter");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Iscancel).HasColumnName("iscancel");
            entity.Property(e => e.Isvoid).HasColumnName("isvoid");
            entity.Property(e => e.Numberofdaysleave).HasColumnName("numberofdaysleave");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Startdate)
                .HasColumnType("date")
                .HasColumnName("startdate");
            entity.Property(e => e.Voidedby).HasColumnName("voidedby");
            entity.Property(e => e.Voideddate)
                .HasColumnType("datetime")
                .HasColumnName("voideddate");

            entity.HasOne(d => d.FkEmployeeNavigation).WithMany(p => p.Employeeleaverequests)
                .HasForeignKey(d => d.FkEmployee)
                .HasConstraintName("FK_Employeeleaverequest_employee");

            entity.HasOne(d => d.FkLeavenoticetypeNavigation).WithMany(p => p.Employeeleaverequests)
                .HasForeignKey(d => d.FkLeavenoticetype)
                .HasConstraintName("FK_Employeeleaverequest_noticetype");

            entity.HasOne(d => d.FkLeavetypeNavigation).WithMany(p => p.Employeeleaverequests)
                .HasForeignKey(d => d.FkLeavetype)
                .HasConstraintName("FK_Employeeleaverequest_leavetype");
        });

        modelBuilder.Entity<Employeelicense>(entity =>
        {
            entity.HasKey(e => e.PkEmployeelicense).HasName("PK__employee__0BDB5B28760FAF4E");

            entity.ToTable("employeelicense", "HR");

            entity.Property(e => e.PkEmployeelicense)
                .ValueGeneratedNever()
                .HasColumnName("PK_employeelicense");
            entity.Property(e => e.Createby).HasColumnName("createby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Expirydate)
                .IsUnicode(false)
                .HasColumnName("expirydate");
            entity.Property(e => e.FkEmployee).HasColumnName("FK_employee");
            entity.Property(e => e.FkLicensetype).HasColumnName("FK_licensetype");
            entity.Property(e => e.Licensenumber)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("licensenumber");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("remarks");

            entity.HasOne(d => d.FkEmployeeNavigation).WithMany(p => p.Employeelicenses)
                .HasForeignKey(d => d.FkEmployee)
                .HasConstraintName("FK_employeelicense_employee");

            entity.HasOne(d => d.FkLicensetypeNavigation).WithMany(p => p.Employeelicenses)
                .HasForeignKey(d => d.FkLicensetype)
                .HasConstraintName("FK_employeelicense_licensetype");
        });

        modelBuilder.Entity<Employmentstatus>(entity =>
        {
            entity.HasKey(e => e.PkEmployment).HasName("PK__employme__C2203DF30E5B31E9");

            entity.ToTable("employmentstatus", "HR");

            entity.Property(e => e.PkEmployment)
                .ValueGeneratedNever()
                .HasColumnName("PK_employment");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Enddate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("enddate");
            entity.Property(e => e.FkEmployee).HasColumnName("FK_employee");
            entity.Property(e => e.FkEmploymenttype).HasColumnName("FK_employmenttype");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("startdate");

            entity.HasOne(d => d.FkEmployeeNavigation).WithMany(p => p.Employmentstatuses)
                .HasForeignKey(d => d.FkEmployee)
                .HasConstraintName("FK_employmentstatus_employee");

            entity.HasOne(d => d.FkEmploymenttypeNavigation).WithMany(p => p.Employmentstatuses)
                .HasForeignKey(d => d.FkEmploymenttype)
                .HasConstraintName("FK_employmentstatus_employment");
        });

        modelBuilder.Entity<Employmenttype>(entity =>
        {
            entity.HasKey(e => e.PkEmploymenttype).HasName("PK__employme__44A7658534EB29FE");

            entity.ToTable("employmenttype", "Template");

            entity.Property(e => e.PkEmploymenttype).HasColumnName("PK_employmenttype");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Leavenoticetype>(entity =>
        {
            entity.HasKey(e => e.PkLeavenoticetype).HasName("PK__leavenot__4EE1D8AE75E9C7ED");

            entity.ToTable("leavenoticetype", "Template");

            entity.Property(e => e.PkLeavenoticetype).HasColumnName("PK_leavenoticetype");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
        });

        modelBuilder.Entity<Leavessetting>(entity =>
        {
            entity.HasKey(e => e.PkLeavessettings).HasName("PK__leavesse__69F91C6F3447F1EE");

            entity.ToTable("leavessettings", "HR");

            entity.Property(e => e.PkLeavessettings)
                .ValueGeneratedNever()
                .HasColumnName("PK_leavessettings");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.FkEmploymenttype).HasColumnName("FK_employmenttype");
            entity.Property(e => e.FkLeavetype).HasColumnName("FK_leavetype");
            entity.Property(e => e.IsBaseYearofService).HasColumnName("isBaseYearofService");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Totaldays).HasColumnName("totaldays");

            entity.HasOne(d => d.FkEmploymenttypeNavigation).WithMany(p => p.Leavessettings)
                .HasForeignKey(d => d.FkEmploymenttype)
                .HasConstraintName("FK_leavessettings_employmenttype");

            entity.HasOne(d => d.FkLeavetypeNavigation).WithMany(p => p.Leavessettings)
                .HasForeignKey(d => d.FkLeavetype)
                .HasConstraintName("FK_leavessettings_leavetype");
        });

        modelBuilder.Entity<Leavetype>(entity =>
        {
            entity.HasKey(e => e.PkLeavetype).HasName("PK__leavetyp__7191D127E8F3682E");

            entity.ToTable("leavetype", "Template");

            entity.Property(e => e.PkLeavetype).HasColumnName("PK_leavetype");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsPaid).HasColumnName("isPaid");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
        });

        modelBuilder.Entity<Licensetype>(entity =>
        {
            entity.HasKey(e => e.PkLicensetype).HasName("PK__licenset__7C12B3D5F3A31B9C");

            entity.ToTable("licensetype", "Template");

            entity.Property(e => e.PkLicensetype).HasColumnName("PK_licensetype");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.HasKey(e => e.PkNationality);

            entity.ToTable("nationality", "Template");

            entity.Property(e => e.PkNationality).HasColumnName("PK_nationality");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");

            entity.HasOne(d => d.FkSystemUserNavigation).WithMany(p => p.Nationalities)
                .HasForeignKey(d => d.FkSystemUser)
                .HasConstraintName("FK_nationality_systemuser");
        });

        modelBuilder.Entity<Offensetype>(entity =>
        {
            entity.HasKey(e => e.PkOffensetype).HasName("PK__offenset__5387B17E70C8F627");

            entity.ToTable("offensetype", "Template");

            entity.Property(e => e.PkOffensetype).HasColumnName("PK_offensetype");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Severity).HasColumnName("severity");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.PkPosition).HasName("PK__position__45BF2676EC25FD34");

            entity.ToTable("position", "Template");

            entity.Property(e => e.PkPosition).HasColumnName("PK_position");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("getdate()")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.FkDepartment).HasColumnName("FK_department");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.PositionName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("positionName");

            entity.HasOne(d => d.FkDepartmentNavigation).WithMany(p => p.Positions)
                .HasForeignKey(d => d.FkDepartment)
                .HasConstraintName("FK_position_department");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.PkProvince);

            entity.ToTable("province", "Template");

            entity.Property(e => e.PkProvince).HasColumnName("PK_province");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkRegion).HasColumnName("FK_region");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("region", "Template");

            entity.Property(e => e.Createdby)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.PkRegion)
                .ValueGeneratedOnAdd()
                .HasColumnName("PK_region");
        });

        modelBuilder.Entity<Relationship>(entity =>
        {
            entity.HasKey(e => e.PkRelationship);

            entity.ToTable("relationship", "Template");

            entity.Property(e => e.PkRelationship).HasColumnName("PK_relationship");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
        });

        modelBuilder.Entity<Religion>(entity =>
        {
            entity.HasKey(e => e.PkReligion).HasName("PK__religion__9D8783A8FB99CC47");

            entity.ToTable("religion", "Template");

            entity.Property(e => e.PkReligion).HasColumnName("PK_religion");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsActive).HasColumnName("isActive");

            entity.HasOne(d => d.FkSystemUserNavigation).WithMany(p => p.Religions)
                .HasForeignKey(d => d.FkSystemUser)
                .HasConstraintName("FK_religion_systemuser");
        });

        modelBuilder.Entity<Salarytype>(entity =>
        {
            entity.HasKey(e => e.PkSalarytype).HasName("PK__salaryty__04B30C0E8B5484ED");

            entity.ToTable("salarytype", "Template");

            entity.Property(e => e.PkSalarytype)
                .ValueGeneratedNever()
                .HasColumnName("PK_salarytype");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkEmployeetype).HasColumnName("FK_employeetype");
            entity.Property(e => e.IsAllowance).HasColumnName("isAllowance");
            entity.Property(e => e.IsBasicPay).HasColumnName("isBasicPay");
            entity.Property(e => e.IsBonus).HasColumnName("isBonus");
            entity.Property(e => e.IsCola).HasColumnName("isCOLA");
            entity.Property(e => e.IsTaxable).HasColumnName("isTaxable");
            entity.Property(e => e.IsThirteenMonth).HasColumnName("isThirteenMonth");
        });

        modelBuilder.Entity<SystemUser>(entity =>
        {
            entity.HasKey(e => e.PkSystemUser);

            entity.ToTable("systemUser", "USERS");

            entity.Property(e => e.PkSystemUser).HasColumnName("PK_systemUser");
            entity.Property(e => e.FkDepartment).HasColumnName("FK_department");
            entity.Property(e => e.FkPosition).HasColumnName("FK_position");
            entity.Property(e => e.FkSystemUserGroup).HasColumnName("FK_systemUserGroup");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Logdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("logdate");
            entity.Property(e => e.Usercode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usercode");
            entity.Property(e => e.Userpass)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("userpass");

            entity.HasOne(d => d.FkDepartmentNavigation).WithMany(p => p.SystemUsers)
                .HasForeignKey(d => d.FkDepartment)
                .HasConstraintName("FK_department_systemuser");

            entity.HasOne(d => d.FkPositionNavigation).WithMany(p => p.SystemUsers)
                .HasForeignKey(d => d.FkPosition)
                .HasConstraintName("FK_position_systemUser");
        });

        modelBuilder.Entity<Towncity>(entity =>
        {
            entity.HasKey(e => e.PkTowncity).HasName("PK__towncity__BDEBF576E4BE7ECC");

            entity.ToTable("towncity", "Template");

            entity.Property(e => e.PkTowncity)
                .ValueGeneratedNever()
                .HasColumnName("PK_towncity");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FkProvince).HasColumnName("FK_Province");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Wagefactor>(entity =>
        {
            entity.HasKey(e => e.PkWagefactor).HasName("PK__wagefact__76FBFEE5696BFCA1");

            entity.ToTable("wagefactor", "Template");

            entity.Property(e => e.PkWagefactor)
                .ValueGeneratedNever()
                .HasColumnName("PK_wagefactor");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
        });

        modelBuilder.Entity<Workassignment>(entity =>
        {
            entity.HasKey(e => e.PkWorkassignment).HasName("PK__workassi__6026C9DAAFCF236E");

            entity.ToTable("workassignment", "HR");

            entity.Property(e => e.PkWorkassignment).HasColumnName("PK_workassignment");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Enddate)
                .HasColumnType("date")
                .HasColumnName("enddate");
            entity.Property(e => e.FkDepartment).HasColumnName("FK_department");
            entity.Property(e => e.FkEmployee).HasColumnName("FK_employee");
            entity.Property(e => e.FkPosition).HasColumnName("FK_position");
            entity.Property(e => e.FkSystemUser).HasColumnName("FK_systemUser");
            entity.Property(e => e.IsManager).HasColumnName("isManager");
            entity.Property(e => e.Jobdescription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("jobdescription");
            entity.Property(e => e.Jobscope)
                .IsUnicode(false)
                .HasColumnName("jobscope");
            entity.Property(e => e.Responsibilities)
                .IsUnicode(false)
                .HasColumnName("responsibilities");
            entity.Property(e => e.Startdate)
                .HasColumnType("date")
                .HasColumnName("startdate");

            entity.HasOne(d => d.FkDepartmentNavigation).WithMany(p => p.Workassignments)
                .HasForeignKey(d => d.FkDepartment)
                .HasConstraintName("FK_workassignment_department");

            entity.HasOne(d => d.FkEmployeeNavigation).WithMany(p => p.Workassignments)
                .HasForeignKey(d => d.FkEmployee)
                .HasConstraintName("FK_workassignment_employee");

            entity.HasOne(d => d.FkPositionNavigation).WithMany(p => p.Workassignments)
                .HasForeignKey(d => d.FkPosition)
                .HasConstraintName("FK_workassignment_position");

            entity.HasOne(d => d.FkSystemUserNavigation).WithMany(p => p.Workassignments)
                .HasForeignKey(d => d.FkSystemUser)
                .HasConstraintName("FK_workassignment_systemuser");
        });

        modelBuilder.Entity<Zipcode>(entity =>
        {
            entity.HasKey(e => e.PkZipcode);

            entity.ToTable("zipcode", "Template");

            entity.Property(e => e.PkZipcode).HasColumnName("PK_zipcode");
            entity.Property(e => e.Areaname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("areaname");
            entity.Property(e => e.Createdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.FkTowncity).HasColumnName("FK_towncity");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Zipcode1).HasColumnName("zipcode");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
