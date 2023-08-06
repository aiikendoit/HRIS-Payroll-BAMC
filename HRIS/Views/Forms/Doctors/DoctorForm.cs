using HRIS.Class;
using HRIS.Forms.Employee;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Doctors
{
    public partial class DoctorForm : Form, IEmployeeView
    {
        private readonly employee_Presenter employee_Presenter;
        public DoctorForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_doctors);
            employee_Presenter = new employee_Presenter(this);
            employee_Presenter.loadDoctorJoin(dgrid_doctors);

        }
        private void changeDgridSize()
        {
            dgrid_doctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgrid_doctors.Columns[0].Visible = false;
            dgrid_doctors.Columns[1].Width = 30;
            dgrid_doctors.Columns[2].Width = 80;
            dgrid_doctors.Columns["Name"].Width = 250;
            dgrid_doctors.Columns["Gender"].Width = 100;
            dgrid_doctors.Columns["IsActive"].Width = 100;
            dgrid_doctors.Columns["Department"].Width = 200;
            dgrid_doctors.Columns["Position"].Width = 100;
            dgrid_doctors.Columns["Address"].Width = dgrid_doctors.Width - 30 - 80 - 250 - 400 - 100;
            dgrid_doctors.Columns[1].HeaderText = "";
            foreach (DataGridViewColumn column in dgrid_doctors.Columns)
            {
                if (column is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)column).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }

        }

        public void DisplayEmployee(List<Models.Employee> employees)
        {
            dgrid_doctors.DataSource = employees;
        }

        public void DisplayEmployeeAllDetails(List<Models.Employee> employees)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string docname = "Doctor";
            EmployeeRegistration employeeForm = new EmployeeRegistration(docname);

            employeeForm.ShowDialog();
            employee_Presenter.loadDoctorJoin(dgrid_doctors);
        }

        private void s_Click(object sender, EventArgs e)
        {
            string docname = "Doctor";
            string? position = dgrid_doctors.SelectedRows[0].Cells["Position"].Value?.ToString() ?? string.Empty;
            string? department = dgrid_doctors.SelectedRows[0].Cells["Department"].Value?.ToString() ?? string.Empty;
            int selectedEmployee = (int)dgrid_doctors.SelectedRows[0].Cells["ID"].Value;

            var emp = new EmployeeRegistration(docname);
            emp.loadallCombobox();
            emp.putdataDoctor(selectedEmployee, position, department);
            emp.ShowDialog(this);

        }

        private void DoctorForm_Shown(object sender, EventArgs e)
        {
            changeDgridSize();
        }
    }
}
