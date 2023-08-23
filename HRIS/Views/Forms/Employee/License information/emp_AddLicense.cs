using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.License_information;
using HRIS.Views.Forms.Maintenance.License;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HRIS.Forms.Employee.License_information
{
    public partial class emp_AddLicense : Form, ILicenseTypeView, IEmployeelicenseInformationView
    {
        private readonly licensetype_Presenter licensetype_Presenter;
        private readonly employeelicenseinformation_Presenter employeelicenseinformation_Presenter;
        private readonly HrisContext _context;
        private int EmpID;
        public int licenseID;
        public bool isUpdate;
        public emp_AddLicense(int PkEmployee)
        {
            InitializeComponent();
            licensetype_Presenter = new licensetype_Presenter(this);
            employeelicenseinformation_Presenter = new employeelicenseinformation_Presenter(this);
            _context = new HrisContext();
            licensetype_Presenter.LoadLicentype();
            EmpID = PkEmployee;
        }

        public void DisplaylicenseInfo(List<object> licenseInfo)
        {
            // throw new NotImplementedException();
        }

        public void DisplayLicensetype(List<Licensetype> licenseTypes)
        {
            txt_licensetype.DataSource = licenseTypes;
            txt_licensetype.ValueMember = "PkLicensetype";
            txt_licensetype.DisplayMember = "Description";
        }
        public void putdata(int PKLicense)
        {
            if (isUpdate)
            {
                btn_cancel.Select();
                employeelicenseinformation_Presenter.LoadLicenseInfo(PKLicense);
                licenseID = PKLicense;
            }
            else
            {
                btn_cancel.Select();
                employeelicenseinformation_Presenter.LoadLicenseInfo(PKLicense);
                //disable control
                foreach (Control control in this.Controls)
                {
                    

                    if (control.Name == "txt_remarks")
                    {
                        TextBox txtBox = control as TextBox;
                        if (txtBox != null)
                        {
                            txtBox.ReadOnly = true;
                        }
                    }
                    else
                    {
                        if (!(control is Label) && !(control is Button))
                        {
                            control.Enabled = false;
                        }
                    }
                }
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_licensenumber) && UniversalStatic.IsEmpty(txt_remarks)) return;
            //if (UniversalStatic.IsEmpty(txt_expiryreminder)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Employeelicense
            {
                FkEmployee = EmpID,
                FkLicensetype = Convert.ToInt32(txt_licensetype.SelectedValue),
                Licensenumber = txt_licensenumber.Text,
                Expirydate = txt_expirydate.Value,
                Remarks = txt_remarks.Text,
                Createdby = createdby,
                FkSystemUser = id
            };
            employeelicenseinformation_Presenter.AddEmployeeLicense(cv);
            this.Close();
        }
        private void update()
        {

            var existinglicense = _context.Employeelicenses.Find(licenseID);
            if (existinglicense != null)
            {
                existinglicense.FkEmployee = EmpID;
                existinglicense.FkLicensetype = Convert.ToInt32(txt_licensetype.SelectedValue);
                existinglicense.Licensenumber = txt_licensenumber.Text;
                existinglicense.Expirydate = txt_expirydate.Value;
                existinglicense.Remarks = txt_remarks.Text;
                employeelicenseinformation_Presenter.UpdateEmployeeLicense(existinglicense);
                this.Close();
            }

        }

        public void DisplayLicenseInformation(List<Employeelicense> employeelicenses)
        {
            try
            {
                Models.Employeelicense license = employeelicenses[0];
                txt_licensetype.SelectedValue = license.FkLicensetype;
                txt_licensenumber.Text = license.Licensenumber;
                txt_expirydate.Value = license.Expirydate;
                txt_remarks.Text = license.Remarks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplaylicenseInfoCustom(List<object> licenseInfo)
        {
            //  throw new NotImplementedException();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                update();
            }
            else
            {
                save();
            }
        }
    }
}
