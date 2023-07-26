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
            employee_Presenter.loadEmployeeJoin();
            changeDgridSize();
        }

        public void DisplayEmployee(List<Models.Employee> employees)
        {

            dgrid_employee.DataSource = employees;
            //changeDgridSize();
        }
        private void changeDgridSize()
        {
            DataGridView dataGridView = dgrid_employee;
            int[] columnsToKeep = new int[] { 0, 1, 4, 10, 35, 14, 34 };
            //if (dgrid_employee.ColumnCount == 60)
            //{
                for (int i = dataGridView.Columns.Count - 1; i >= 0; i--)
                {
                    if (!columnsToKeep.Contains(i))
                    {
                        dataGridView.Columns.RemoveAt(i);
                    }
                }
          //  }
            dgrid_employee.AutoGenerateColumns = false;
            dgrid_employee.Columns[0].Visible = false;
            dgrid_employee.Columns[0].Width = 10;
            dgrid_employee.Columns[1].Width = 80;
            dgrid_employee.Columns[2].Width = 250;
            dgrid_employee.Columns[3].Width = 120;
            dgrid_employee.Columns[4].Width = 350;
            dgrid_employee.Columns[0].HeaderText = "ID";
            dgrid_employee.Columns[1].HeaderText = "Employee Code";
            dgrid_employee.Columns[2].HeaderText = "Name";
            dgrid_employee.Columns[3].HeaderText = "Gender";
            dgrid_employee.Columns[4].HeaderText = "Address";
            dgrid_employee.Columns[5].HeaderText = "";
            //change profile image layout to zoom
            foreach (DataGridViewColumn column in dgrid_employee.Columns)
            {
                if (column is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)column).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            ChangeColumnIndex("", 0, 22);

        }
        private void ChangeColumnIndex(string headerText, int newIndex, int newWidth)
        {
            DataGridViewColumn? column = dgrid_employee.Columns.Cast<DataGridViewColumn>()
                                                .FirstOrDefault(c => c.HeaderText == headerText);

            if (column == null || newIndex < 0 || newIndex >= dgrid_employee.Columns.Count)
            {
                // Invalid column or index
                return;
            }

            column.DisplayIndex = newIndex;
            column.Width = newWidth;
        }




        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
        private void loademployee()
        {
            employee_Presenter.loadEmployeeJoin();
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
            //var selectedEmployee = dgrid_employee.SelectedRows[0].Cells["PKEmployee"].Value;
            var selectedEmployee = dgrid_employee.SelectedRows[0].DataBoundItem as Models.Employee;
            if (selectedEmployee != null)
            {
                var emp = new EmployeeRegistration(docname);
                emp.loadallCombobox();
                emp.putdata(this, selectedEmployee);
                emp.ShowDialog(this);
                loademployee();
            }
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

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txt_search.Text.Trim();
            //var employees = (List<Models.Employee>)dgrid_employee.DataSource;

            //var searchResults = employees.Where(emp =>
            //emp.Lastname.Contains(searchQuery) ||
            //emp.Idno.Contains(searchQuery)).ToList();
            //dgrid_employee.DataSource = searchResults;



            var employees = (List<Models.Employee>)dgrid_employee.DataSource;
            if (string.IsNullOrEmpty(searchQuery))
            {
                loademployee();
            }
            else
            {
                var searchResults = employees.Where(emp =>
                 emp.Idno.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                 emp.Lastname.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();

                dgrid_employee.DataSource = searchResults;
            }


        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string docname = "Employee";
            //var selectedEmployee = dgrid_employee.SelectedRows[0].Cells["PKEmployee"].Value;
            var selectedEmployee = dgrid_employee.SelectedRows[0].DataBoundItem as Models.Employee;
            if (selectedEmployee != null)
            {
                var emp = new EmployeeRegistration(docname);
                emp.loadallCombobox();
                emp.putdata(this, selectedEmployee);
                emp.disablecontrolforView();
                emp.ShowDialog(this);
                loademployee();
            }
        }
    }
}
