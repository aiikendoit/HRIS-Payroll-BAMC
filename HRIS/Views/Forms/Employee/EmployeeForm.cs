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
        private readonly employee_Presenter employee_Presenter;
        public EmployeeForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_employee);

            employee_Presenter = new employee_Presenter(this);
            employee_Presenter.loadEmployeeJoin_Active();
        }

        public void DisplayEmployee(List<Models.Employee> employees)
        {
        }
        private void changeDgridSize()
        {
            dgrid_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgrid_employee.Columns[0].Visible = false;
            dgrid_employee.Columns[1].Width = 30;
            dgrid_employee.Columns[2].Width = 80;
            dgrid_employee.Columns["Name"].Width = 250;
            dgrid_employee.Columns["Gender"].Width = 100;
            dgrid_employee.Columns["Department"].Width = 200;
            dgrid_employee.Columns["Position"].Width = 150;
            dgrid_employee.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_employee.Columns["EmployeeID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgrid_employee.Columns[1].HeaderText = "";
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

        }
        private void loademployee_Active()
        {
            employee_Presenter.loadEmployeeJoin_Active();
            changeDgridSize();
            btn_new.Visible = true;
        }
        private void loademployee_InActive()
        {
            employee_Presenter.loadEmployeeJoin_InActive();
            changeDgridSize();
            btn_new.Visible = false;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string emptype = "Employee";
            var se = new EmployeeSearch(emptype);
            se.ShowDialog();
            //string docname = "Employee";
            //EmployeeRegistration employeeRegistration = new EmployeeRegistration(docname);
            //employeeRegistration.ShowDialog();
            //loademployee_Active();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string docname = "Employee";
            string? position = dgrid_employee.SelectedRows[0].Cells["Position"].Value?.ToString() ?? string.Empty;
            string? department = dgrid_employee.SelectedRows[0].Cells["Department"].Value?.ToString() ?? string.Empty;
            int PKEmployeeID = (int)dgrid_employee.SelectedRows[0].Cells["ID"].Value;

            var emp = new EmployeeRegistration(docname);
            emp.isUpdate = true;
            emp.loadallCombobox();
            emp.putdata(PKEmployeeID, position, department);
            emp.ShowDialog(this);
            loademployee_Active();

        }

        public void DisplayEmployeeAllDetails(List<Models.Employee> employees)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loademployee_Active();
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
                loademployee_Active();
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
            int PKEmployeeID = (int)dgrid_employee.SelectedRows[0].Cells["ID"].Value;

            var emp = new EmployeeRegistration(docname);
            emp.loadallCombobox();
            emp.putdata(PKEmployeeID, position, department);
            emp.ShowDialog(this);
            loademployee_Active();

        }

        public void DisplayEmployeeCustomView(List<object> employees)
        {
            dgrid_employee.DataSource = employees;
            changeDgridSize();
            txt_totalcount.Text = "Total count(s): " + dgrid_employee.RowCount.ToString();
        }

        private void btn_inactiveEmployee_Click(object sender, EventArgs e)
        {
            loademployee_InActive();
        }
    }
}
