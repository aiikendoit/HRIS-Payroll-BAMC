using HRIS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_employee);
            newcolumn();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
        private void newcolumn()
        {
            dgrid_employee.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "ID #"

            });
            dgrid_employee.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Employee"
            });
            dgrid_employee.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Department"
            });
            dgrid_employee.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Address"
            });
            dgrid_employee.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Contact Number"
            });

            dgrid_employee.Rows.Add("17197", "James Palin", "IT Support", "Brgy. Taculing Bacolod City", "09978246900");
            dgrid_employee.Rows.Add("17197", "James Palin", "IT Support", "Brgy. Taculing Bacolod City", "09978246900");

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string docname = "Employee";
            EmployeeRegistration employeeRegistration = new EmployeeRegistration(docname);
            employeeRegistration.ShowDialog();
        }
    }
}
