using HRIS.Class;
using HRIS.Forms.Employee;
using HRIS.Models;
using HRIS.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Employee
{
    public partial class EmployeeSearch : Form, IEmployeeView
    {
        private readonly employee_Presenter employee_Presenter;
        private string emptype = string.Empty;
        public EmployeeSearch(string employeetype)
        {
            InitializeComponent();
            employee_Presenter = new employee_Presenter(this);
            UniversalStatic.customDatagrid(dgrid_employee);
            emptype = employeetype.ToString();
        }

        public void DisplayEmployee(List<Models.Employee> employees)
        {
            //throw new NotImplementedException();
        }

        public void DisplayEmployeeAllDetails(List<Models.Employee> employees)
        {

        }

        public void DisplayEmployeeCustomView(List<object> employees)
        {
            dgrid_employee.AutoGenerateColumns = false;
            dgrid_employee.Columns["ID"].DataPropertyName = "ID"; // Map to your property names
            dgrid_employee.Columns["EmployeeID"].DataPropertyName = "EmployeeID";
            dgrid_employee.Columns["Firstname"].DataPropertyName = "Firstname";
            dgrid_employee.Columns["MiddleName"].DataPropertyName = "MiddleName";
            dgrid_employee.Columns["Lastname"].DataPropertyName = "LastName";
            dgrid_employee.Columns["Suffix"].DataPropertyName = "Suffix";
            dgrid_employee.Columns["Gender"].DataPropertyName = "Gender";
            dgrid_employee.Columns["Birthday"].DataPropertyName = "Birthday";                                                               // ... Map other columns as needed
            dgrid_employee.DataSource = employees;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (UniversalStatic.IsEmpty(txt_lastname)) return;
            if (UniversalStatic.IsEmpty(txt_firstname)) return;
            search();
        }
        private void search()
        {
            string lastname = txt_lastname.Text;
            string firstname = txt_firstname.Text;
            employee_Presenter.LoadAllSearchEmployee(lastname, firstname);

            if (dgrid_employee.RowCount == 0) // Check if data grid is empty
            {
                // Data grid is empty, disable the button
                btn_newEmployee.Enabled = true;
            }
            else
            {
                // Data grid has rows, enable the button
                btn_newEmployee.Enabled = false;
            }
        }

        private void dgrid_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editEmployee.Visible = true;
        }

        private void btn_newEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            string docname = emptype;
            var emp = new EmployeeRegistration(docname);
            emp.putDataNewEmployee(txt_lastname.Text, txt_firstname.Text);
            emp.ShowDialog();
        }

        private void btn_editEmployee_Click(object sender, EventArgs e)
        {
            string docname = emptype;
            int PKEmployeeID = (int)dgrid_employee.SelectedRows[0].Cells["ID"].Value;
            var emp = new EmployeeRegistration(docname);
            emp.isUpdate = true;
            emp.loadallCombobox();
            emp.putdata(PKEmployeeID,true);
            emp.ShowDialog(this);

        }

        public void DisplayEmployeeInActive(List<object> employees)
        {
            throw new NotImplementedException();
        }

        private void EmployeeSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (UniversalStatic.IsEmpty(txt_lastname)) return;
                if (UniversalStatic.IsEmpty(txt_firstname)) return;
                search();
            }
        }
    }
}
