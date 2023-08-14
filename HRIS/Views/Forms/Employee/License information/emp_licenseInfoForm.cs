using HRIS.Class;
using HRIS.Forms.Employee.Education;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.License_information;
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

namespace HRIS.Forms.Employee.License_information
{
    public partial class emp_licenseInfoForm : Form, IEmployeelicenseInformationView
    {
        int empID = 0;
        private readonly employeelicenseinformation_Presenter employeelicenseinformation_Presenter;
        private readonly HrisContext _context;
        public emp_licenseInfoForm(int PKEmployeeID)
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_license);
            employeelicenseinformation_Presenter = new employeelicenseinformation_Presenter(this);
            _context = new HrisContext();
            empID = PKEmployeeID;
            loadLicenseinformation();
        }
        private void emp_licenseInfoForm_Load(object sender, EventArgs e)
        {

        }
        private void loadLicenseinformation()
        {
            employeelicenseinformation_Presenter.LoadLicenseInformationCustom(empID);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            emp_AddLicense emp_AddLicense = new emp_AddLicense(empID);
            emp_AddLicense.ShowDialog();
            loadLicenseinformation();
        }

        public void DisplayLicenseInformation(List<Employeelicense> employeelicenses)
        {
            // throw new NotImplementedException();
        }

        public void DisplaylicenseInfoCustom(List<object> licenseInfo)
        {
            if (licenseInfo != null && licenseInfo.Count > 0)
            {
                dgrid_license.AutoGenerateColumns = false;
                dgrid_license.Columns["LicenseID"].DataPropertyName = "ID";
                dgrid_license.Columns["LicenseType"].DataPropertyName = "LicenseType";
                dgrid_license.Columns["LicenseNumber"].DataPropertyName = "LicenseNumber";
                dgrid_license.Columns["Expirydate"].DataPropertyName = "ExpiryDate";
                dgrid_license.Columns["ExpiryReminder"].DataPropertyName = "Remarks";
                dgrid_license.DataSource = licenseInfo;
            }
            else
            {
                dgrid_license.DataSource = null; // Clear the DataGridView if licenseInfo is empty
            }
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            var licenseid = dgrid_license.SelectedRows[0].Cells[0].Value;
            var lic = new emp_AddLicense(empID);
            lic.isUpdate = true;
            lic.putdata(Convert.ToInt32(licenseid));
            lic.ShowDialog();
            loadLicenseinformation();
        }

        private void dgrid_license_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgrid_license.Columns[0].Width = 50;
            dgrid_license.Columns[1].Width = 150;
            dgrid_license.Columns[2].Width = 100;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var licenseid = dgrid_license.SelectedRows[0].Cells[0].Value;
            var lic = new emp_AddLicense(empID);
            lic.isUpdate = false;
            lic.putdata(Convert.ToInt32(licenseid));
            lic.ShowDialog();
            loadLicenseinformation();
        }
        private void Search()
        {
            string searchQuery = txt_search.Text;
            employeelicenseinformation_Presenter.SearchData(searchQuery);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadLicenseinformation();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void delete(int licenseID)
        {
            var existinglicense = _context.Employeelicenses.Find(licenseID);
            if (existinglicense != null)
            {
                existinglicense.IsDeleted = true;
                employeelicenseinformation_Presenter.DeleteEmployeeLicense(existinglicense);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {

            int licenseid = (int)dgrid_license.SelectedRows[0].Cells[0].Value;
            string? licensetype = dgrid_license.SelectedRows[0].Cells[1].Value.ToString();
            if (licenseid != 0)
            {
                if (MessageBox.Show("Are you sure to delete " + licensetype,
                    "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    delete(licenseid);
                    loadLicenseinformation();
                }
            }

        }
    }
}
