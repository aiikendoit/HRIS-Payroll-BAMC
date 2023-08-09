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
            employee_Presenter.loadEmployeeJoin(dgrid_employee);
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
            dgrid_employee.Columns["IsActive"].Width = 100;
            dgrid_employee.Columns["Department"].Width = 200;
            dgrid_employee.Columns["Position"].Width = 150;
            dgrid_employee.Columns["Address"].Width = dgrid_employee.Width - 30-80-250-400-100;
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
        private void loademployee()
        {
            employee_Presenter.loadEmployeeJoin(dgrid_employee);
            //changeDgridSize();
        }


        private void iconButton4_Click(object sender, EventArgs e)
        {
            string docname = "Employee";
            EmployeeRegistration employeeRegistration = new EmployeeRegistration(docname);
            employeeRegistration.ShowDialog();
            loademployee();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string docname = "Employee";
            string? position = dgrid_employee.SelectedRows[0].Cells["Position"].Value?.ToString() ?? string.Empty;
            string? department = dgrid_employee.SelectedRows[0].Cells["Department"].Value?.ToString() ?? string.Empty;
            int PKEmployeeID = (int)dgrid_employee.SelectedRows[0].Cells["ID"].Value;

            var emp = new EmployeeRegistration(docname);
            emp.loadallCombobox();
            emp.putdata(PKEmployeeID, position,department);
            emp.ShowDialog(this);
            loademployee();

        }

        public void DisplayEmployeeAllDetails(List<Models.Employee> employees)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loademployee();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchData();
        }
        private void searchData()
        {
            string searchTerm = txt_search.Text.ToLower();
            dgrid_employee.SuspendLayout();

            foreach (DataGridViewRow row in dgrid_employee.Rows)
            {
                bool rowVisible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        rowVisible = true;
                        break;
                    }
                }
                row.Visible = rowVisible;
            }
            dgrid_employee.ResumeLayout();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            searchData();

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string docname = "Employee";
            string? position = dgrid_employee.SelectedRows[0].Cells["Position"].Value.ToString();
            string? department = dgrid_employee.SelectedRows[0].Cells["Department"].Value.ToString();
            int selectedEmployee = (int)dgrid_employee.SelectedRows[0].Cells["ID"].Value;

            var emp = new EmployeeRegistration(docname);
            emp.loadallCombobox();
            emp.putdata(selectedEmployee,position,department);
            emp.disablecontrolforView();
            emp.ShowDialog(this);
            loademployee();

        }


        private void EmployeeForm_Shown(object sender, EventArgs e)
        {
            changeDgridSize();
        }
    }
}
