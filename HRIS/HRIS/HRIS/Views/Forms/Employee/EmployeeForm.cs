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
<<<<<<< HEAD
<<<<<<< HEAD
            employee_Presenter = new employee_Presenter(this);
            employee_Presenter.loadEmployeeJoin();
            changeDgridSize();
=======
           
            employee_Presenter = new employee_Presenter(this);
            employee_Presenter.loadEmployeeJoin(dgrid_employee);
=======
           
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
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
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
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
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
<<<<<<< HEAD
<<<<<<< HEAD
            employee_Presenter.loadEmployeeJoin();
=======
            employee_Presenter.loadEmployeeJoin(dgrid_employee);
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
            employee_Presenter.loadEmployeeJoin(dgrid_employee);
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
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
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
            string? position = dgrid_employee.SelectedRows[0].Cells["Position"].Value?.ToString() ?? string.Empty;
            string? department = dgrid_employee.SelectedRows[0].Cells["Department"].Value?.ToString() ?? string.Empty;
            int selectedEmployee = (int)dgrid_employee.SelectedRows[0].Cells["ID"].Value;

            var emp = new EmployeeRegistration(docname);
            emp.loadallCombobox();
            emp.putdata(selectedEmployee,position,department);
            emp.ShowDialog(this);
            loademployee();

<<<<<<< HEAD
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
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
<<<<<<< HEAD
<<<<<<< HEAD
            //var employees = (List<Models.Employee>)dgrid_employee.DataSource;

            //var searchResults = employees.Where(emp =>
            //emp.Lastname.Contains(searchQuery) ||
            //emp.Idno.Contains(searchQuery)).ToList();
            //dgrid_employee.DataSource = searchResults;



=======
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
            var employees = (List<Models.Employee>)dgrid_employee.DataSource;
            if (string.IsNullOrEmpty(searchQuery))
            {
                loademployee();
            }
            else
            {
<<<<<<< HEAD
<<<<<<< HEAD
                var searchResults = employees.Where(emp =>
=======
                var searchResults = employees?.Where(emp =>
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
                 emp.Idno.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                 emp.Lastname.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();

=======
                var searchResults = employees?.Where(emp =>
                 emp.Idno.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                 emp.Lastname.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
                dgrid_employee.DataSource = searchResults;
            }


        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string docname = "Employee";
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
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
<<<<<<< HEAD
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
        }
    }
}
