using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.Document;

namespace HRIS.Views.Forms.Employee.Documents
{
    public partial class Add_Docs : Form, IEmployeeView, IDocumentTypeView
    {
        private readonly employee_Presenter emp_Presenter;
        private readonly documenttype_Presenter doctype_Presenter;
        public Add_Docs()
        {
            InitializeComponent();
            doctype_Presenter = new documenttype_Presenter(this);
            doctype_Presenter.LoadDocumenttype();
        }

        public void DisplayDocumentype(List<Doctype> documentTypes)
        {
            comboBox_DocType.DataSource = documentTypes;
            comboBox_DocType.ValueMember = "PkDoctype";
            comboBox_DocType.DisplayMember = "Description";
        }

        public void DisplayEmployee(List<Models.Employee> employees)
        {
            //throw new NotImplementedException();
        }

        public void DisplayEmployeeAllDetails(List<Models.Employee> employees)
        {
            try
            {
                if (employees != null && employees.Count > 0)
                {
                    Models.Employee employee = employees[0];
                    // Navigation
                    //Barangay? barangay = employee.FkBarangayNavigation;
                    //txt_employeeid.Text = employee.Idno;
                    employee_label.Text = employee.Firstname;
                    //txt_lastname.Text = employee.Lastname;
                    //txt_idno.Text = employee.Idno;
                    //txt_biometric.Text = employee.Biometricno;
                    //txt_rfid.Text = employee.Rfid;
                    //txt_lastname.Text = employee.Lastname;
                    //txt_firstname.Text = employee.Firstname;
                    //txt_middlename.Text = employee.Middlename;
                    //txt_suffix.Text = employee.Suffix;
                    //txt_extensionname.Text = employee.Extensionname;
                    //txt_birthdate.Value = employee?.Birthdate ?? DateTime.MinValue;
                    //string? gendertype = employee?.Gender;
                    //if (gendertype == "Male") { radioButton_male.Checked = true; }
                    //if (gendertype == "Female") { radioButton_female.Checked = true; }
                    //address1 = employee?.Address1;
                    //address2 = employee?.Address2;
                    //address3 = employee?.Address3;
                    //provinceSelectedValue = employee?.FkProvince != null ? (int)employee.FkProvince : 0;
                    //towncitySelectedValue = employee?.FkTowncity != null ? (int)employee.FkTowncity : 0;
                    //barangaySelectedValue = employee?.FkBarangay != null ? (int)employee.FkBarangay : 0;
                    //zipcodeSelectedValue = employee?.FkZipcode != null ? (int)employee.FkZipcode : 0;
                    //txt_completeaddress.Text = employee?.Address1 + " " + employee?.Address2 + " " + employee?.Address3
                    //    + " " + employee?.FkBarangayNavigation?.Description
                    //    + " " + employee?.FkTowncityNavigation?.Description
                    //    + " " + employee?.FkProvinceNavigation?.Description
                    //     + " " + employee?.FkZipcodeNavigation?.Zipcode1;

                    //txt_civilstatus.SelectedValue = employee?.FkCivilstatus;
                    //txt_religion.SelectedValue = employee?.FkReligion;
                    //txt_natinality.SelectedValue = employee?.FkNationality;
                    //txt_bloodtype.Text = employee?.Bloodtype;
                    //txt_telephoneno.Text = employee?.Telephoneno;
                    //txt_cellno.Text = employee?.Cellno;
                    //txt_emailaddress.Text = employee?.Email;
                    //txt_educatinlevel.SelectedValue = employee?.FkEducationallevel;
                    //txt_bank.SelectedValue = employee?.FkBankName;
                    //txt_accountnumber.Text = employee?.Accountno;
                    //txt_emergencyContactName.Text = employee?.Contactperson;
                    //txt_relationship_combobox.SelectedValue = employee?.FkRelationship;
                    //txt_emergencyContactno.Text = employee?.Contactno;
                    //txt_sss.Text = employee?.Sssno;
                    //txt_pagibig.Text = employee?.Pagibigno;
                    //txt_philhealth.Text = employee?.Phicno;
                    //txt_tinnumber.Text = employee?.Tinno;
                    //checkBox_isactive.Checked = employee?.IsActive ?? false;
                    //if (employee?.ProfilePicture != null)
                    //{
                    //    Byte[] img;
                    //    img = employee.ProfilePicture;
                    //    MemoryStream memoryStream = new MemoryStream(img);
                    //    profilepic.Image = Image.FromStream(memoryStream);
                    //    picture_avatar.Image = Image.FromStream(memoryStream);
                    //}
                    //string? mdname = employee?.Middlename;
                    //char md;
                    //if (mdname != null && mdname.Length > 0)
                    //{
                    //    md = mdname[0];
                    //    mdname = md.ToString() + ". ";
                    //}
                    //txt_Headercompletename.Text = employee?.Firstname + " " + mdname + employee?.Lastname;
                    //employeeid = employee?.PkEmployee ?? 0;
                    //btn_save.Text = "Update";
                    //btn_cancel.Select();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"An error occurred while saving the entity changes. Inner exception: {ex.InnerException.Message}");
                }
                else
                {
                    MessageBox.Show($"An error occurred while saving the entity changes. Exception: {ex.Message}");
                }
            }
            //dataGridView.DataSource = employees;
            //this.Controls.Add(dataGridView);
        }

        public void DisplayEmployeeCustomView(List<object> employees)
        {
            //throw new NotImplementedException();
        }

        private void Add_Docs_Load(object sender, EventArgs e)
        {

        }
    }
}
