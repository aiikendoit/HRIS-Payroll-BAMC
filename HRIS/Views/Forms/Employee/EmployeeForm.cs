using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee
{
    public partial class EmployeeForm : Form, IEmployeeView
    {

        public bool isViewingArchive = false;
        private readonly employee_Presenter employee_Presenter;
        public EmployeeForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_employee);

            employee_Presenter = new employee_Presenter(this);
            isViewingArchive = false;
            loadEmployee();
            // changeDgridSize();
        }

        public void DisplayEmployee(List<Models.Employee> employees)
        {
        }
        private void changeDgridSize()
        {

            dgrid_employee.Columns[0].Visible = false;
            dgrid_employee.Columns["Gender"].Width = 80;
            dgrid_employee.Columns["Department"].Width = 250;
            dgrid_employee.Columns["Position"].Width = 160;
            dgrid_employee.Columns["EmploymentStatus"].Width = 250;
            //dgrid_employee.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_employee.Columns["EmployeeID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgrid_employee.Columns[1].HeaderText = "";
            int totalColumnWidth = 0;

            // Calculate the sum of column widths
            foreach (DataGridViewColumn column in dgrid_employee.Columns)
            {
                totalColumnWidth += column.Width;
            }
            //MessageBox.Show(totalColumnWidth.ToString());
            //MessageBox.Show(dgrid_employee.Width.ToString());
            if (totalColumnWidth < dgrid_employee.Width)
            {
                dgrid_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgrid_employee.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dgrid_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgrid_employee.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            //Image Column
            foreach (DataGridViewColumn column in dgrid_employee.Columns)
            {
                if (column is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)column).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            changeDgridSize();
        }
        private void loadEmployee()
        {
            if (isViewingArchive)
            {
                employee_Presenter.loadEmployeeJoin_InActive();
                btn_new.Visible = false;
            }
            else
            {
                employee_Presenter.loadEmployeeJoin_Active();
                btn_new.Visible = true;
            }
            //changeDgridSize();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string emptype = "Employee";
            var se = new EmployeeSearch(emptype);
            se.ShowDialog();
            string docname = "Employee";
            EmployeeRegistration employeeRegistration = new EmployeeRegistration(docname);
            employeeRegistration.ShowDialog();
            loadEmployee();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string docname = "Employee";
            string? position = dgrid_employee.SelectedRows[0].Cells["Position"].Value?.ToString() ?? string.Empty;
            string? department = dgrid_employee.SelectedRows[0].Cells["Department"].Value?.ToString() ?? string.Empty;
            int PKEmployeeID = (int)dgrid_employee.SelectedRows[0].Cells["PKEmployeeID"].Value;

            var emp = new EmployeeRegistration(docname);
            emp.isUpdate = true;
            emp.loadallCombobox();
            emp.putdata(PKEmployeeID, position, department);
            emp.ShowDialog(this);
            loadEmployee();

        }

        public void DisplayEmployeeAllDetails(List<Models.Employee> employees)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadEmployee();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchData();
        }
        private void searchData()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                loadEmployee();
            }
            else
            {
                employee_Presenter.SearchData(searchQuery);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            searchData();

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string docname = "Employee";
            string? position = dgrid_employee.SelectedRows[0].Cells["Position"].Value?.ToString() ?? string.Empty;
            string? department = dgrid_employee.SelectedRows[0].Cells["Department"].Value?.ToString() ?? string.Empty;
            int PKEmployeeID = (int)dgrid_employee.SelectedRows[0].Cells["PKEmployeeID"].Value;

            var emp = new EmployeeRegistration(docname);
            emp.loadallCombobox();
            emp.putdata(PKEmployeeID, position, department);
            emp.ShowDialog(this);
            loadEmployee();

        }

        public void DisplayEmployeeCustomView(List<object> employees)
        {

            dgrid_employee.AutoGenerateColumns = false;
            if (employees != null && employees.Count > 0)
            {
                dgrid_employee.DataSource = null;
                dgrid_employee.AutoGenerateColumns = false;
                dgrid_employee.Columns["PKEmployeeID"].DataPropertyName = "ID";
                dgrid_employee.Columns["ProfilePicture"].DataPropertyName = "ProfilePicture";
                dgrid_employee.Columns["EmployeeID"].DataPropertyName = "EmployeeID";
                dgrid_employee.Columns["Name"].DataPropertyName = "Name";
                dgrid_employee.Columns["Gender"].DataPropertyName = "Gender";
                dgrid_employee.Columns["Department"].DataPropertyName = "Department";
                dgrid_employee.Columns["Position"].DataPropertyName = "Position";
                dgrid_employee.Columns["EmploymentStatus"].DataPropertyName = "EmploymentStatus";
                dgrid_employee.Columns["Address"].DataPropertyName = "Address";
                dgrid_employee.DataSource = employees;
            }
            else
            {
                dgrid_employee.DataSource = null;
            }
            txt_totalcount.Text = "Total count(s): " + dgrid_employee.RowCount.ToString();
        }

        private void btn_inactiveEmployee_Click(object sender, EventArgs e)
        {
            isViewingArchive = true;
            loadEmployee();
        }

        private void dgrid_employee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            dgrid_employee.Columns[1].Width = 30;
            dgrid_employee.Columns[2].Width = 100;
            dgrid_employee.Columns["Name"].Width = 250;

        }


        private void dgrid_employee_SizeChanged(object sender, EventArgs e)
        {
            changeDgridSize();
        }


        private void dgrid_employee_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
