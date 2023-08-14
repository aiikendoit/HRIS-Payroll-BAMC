using HRIS.Class;
using HRIS.Forms.Employee.License_information;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Employment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee.Employment
{
    public partial class emp_employmentForm : Form, IEmployeeEmploymentView
    {
        private readonly employeeemploymentstatus_Presenter employeeemploymentstatus_Presenter;
        int empID = 0;
        private readonly HrisContext _context;
        public emp_employmentForm(int PKEmployeeID)
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_employment);
            employeeemploymentstatus_Presenter = new employeeemploymentstatus_Presenter(this);
            _context = new HrisContext();
            empID = PKEmployeeID;
            //load all the data
            loadEmploymentStatus();
        }
        private void loadEmploymentStatus()
        {
            employeeemploymentstatus_Presenter.LoadEmployeeEmploymentStatusCustom(empID);
        }
        private void emp_employmentForm_Load(object sender, EventArgs e)
        {

        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            emp_AddEmployment emp_AddEmployment = new emp_AddEmployment(empID);
            emp_AddEmployment.ShowDialog();
            loadEmploymentStatus();
        }

        public void DisplayEmployeeEmploymentCustom(List<object> employment)
        {
            if (employment != null && employment.Count > 0)
            {
                dgrid_employment.AutoGenerateColumns = false;
                dgrid_employment.Columns["EmploymentID"].DataPropertyName = "ID";
                dgrid_employment.Columns["Employmenttype"].DataPropertyName = "Employmenttype";
                dgrid_employment.Columns["EmploymentStartDate"].DataPropertyName = "Startdate";
                dgrid_employment.Columns["EmploymentEndDate"].DataPropertyName = "Enddate";
                dgrid_employment.Columns["EmploymentRemarks"].DataPropertyName = "Remarks";
                dgrid_employment.DataSource = employment;
                txt_totalcount.Text = "Total record(s): " + employment.Count;
            }
            else
            {
                dgrid_employment.DataSource = null; // Clear the DataGridView if licenseInfo is empty
            }
        }

        public void DisplayEmployeeEmploymentAll(List<Employmentstatus> employmentstatuses)
        {
            //throw new NotImplementedException();
        }
        private void Search()
        {
            string searchQuery = txt_search.Text;
            employeeemploymentstatus_Presenter.SearchData(searchQuery);
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var employmentid = dgrid_employment.SelectedRows[0].Cells[1].Value;
            var lic = new emp_AddEmployment(empID);
            lic.isUpdate = true;
            lic.putdata(Convert.ToInt32(employmentid));
            lic.ShowDialog();
            loadEmploymentStatus();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var employmentid = dgrid_employment.SelectedRows[0].Cells[1].Value;
            var lic = new emp_AddEmployment(empID);
            lic.putdata(Convert.ToInt32(employmentid));
            lic.ShowDialog();
            loadEmploymentStatus();
        }
        private void delete(int licenseID)
        {
            var existingEmploymentStatus = _context.Employmentstatuses.Find(licenseID);
            if (existingEmploymentStatus != null)
            {
                existingEmploymentStatus.IsDeleted = true;
                employeeemploymentstatus_Presenter.DeleteEmploymentStatus(existingEmploymentStatus);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int employmentid = (int)dgrid_employment.SelectedRows[0].Cells["EmploymentID"].Value;
            string? employmentytpe = dgrid_employment.SelectedRows[0].Cells[2].Value.ToString();
            if (employmentid != 0)
            {
                if (MessageBox.Show("Are you sure to delete " + employmentytpe,
                    "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    delete(employmentid);
                    loadEmploymentStatus();
                }
            }
        }

        private void dgrid_employment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgrid_employment.Columns[0].Width = 10;
            if (dgrid_employment.Columns[e.ColumnIndex].Name == "EmploymentEndDate" && e.RowIndex >= 0)
            {
                DataGridViewCell statusCell = dgrid_employment.Rows[e.RowIndex].Cells["EmpStatus"];
                DataGridViewCell endDateCell = dgrid_employment.Rows[e.RowIndex].Cells["EmploymentEndDate"];

                if (endDateCell.Value != null)
                {
                    DateTime endDate = (DateTime)endDateCell.Value; // Assuming the value is of type DateTime
                    DateTime currentDate = DateTime.Now;

                    if (endDate > currentDate)
                    {
                        // Set the background color to green if End Date is in the future
                        statusCell.Style.BackColor = Color.Green;
                        statusCell.Style.SelectionBackColor = Color.Green;
                        statusCell.ToolTipText = "Active";
                    }
                    else
                    {
                        // Set the background color to red if End Date is in the past
                        statusCell.Style.BackColor = Color.Red;
                        statusCell.Style.SelectionBackColor = Color.Red;
                        statusCell.ToolTipText = "Inactive";
                    }
                }
                else
                {
                    // Set the background color to green if End Date is null
                    statusCell.Style.BackColor = Color.Green;
                    statusCell.Style.SelectionBackColor = Color.Green;
                    statusCell.ToolTipText = "Active";
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadEmploymentStatus();
        }

        private void dgrid_employment_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dgrid_employment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_employment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgrid_employment.SelectedRows[0];
                DataGridViewCell endDateCell = selectedRow.Cells["EmploymentEndDate"];

                DateTime currentDate = DateTime.Now; // Current date

                if (endDateCell.Value != null)
                {
                    DateTime endDate = (DateTime)endDateCell.Value;

                    if (endDateCell.Value != null && endDate > currentDate)
                    {
                        // Enable the edit button if End Date is in the past or today
                        btn_edit.Enabled = true;
                        btn_edit.IconColor = Color.White;
                       
                    }
                    else
                    {
                        // Disable the edit button if End Date is in the future or not null
                        btn_edit.Enabled = false;
                        btn_edit.IconColor = Color.DarkGray;
                    }
                }
                else
                {
                    // Enable the edit button if End Date is null
                    btn_edit.Enabled = true;
                    btn_edit.IconColor = Color.White;
                }
            }

        }

    }
}
