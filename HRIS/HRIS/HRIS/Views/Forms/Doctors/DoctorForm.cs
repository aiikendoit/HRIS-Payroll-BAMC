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
<<<<<<< HEAD
            employee_Presenter.loadDoctorJoin();
            changeDgridSize();
        }
        private void changeDgridSize()
        {
            DataGridView dataGridView = dgrid_doctors;
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
            dgrid_doctors.AutoGenerateColumns = false;
            dgrid_doctors.Columns[0].Visible = false;
            dgrid_doctors.Columns[0].Width = 10;
            dgrid_doctors.Columns[1].Width = 80;
            dgrid_doctors.Columns[2].Width = 250;
            dgrid_doctors.Columns[3].Width = 120;
            dgrid_doctors.Columns[4].Width = 350;
            dgrid_doctors.Columns[0].HeaderText = "ID";
            dgrid_doctors.Columns[1].HeaderText = "Employee Code";
            dgrid_doctors.Columns[2].HeaderText = "Name";
            dgrid_doctors.Columns[3].HeaderText = "Gender";
            dgrid_doctors.Columns[4].HeaderText = "Address";
            dgrid_doctors.Columns[5].HeaderText = "";
            //change profile image layout to zoom
=======
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
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
            foreach (DataGridViewColumn column in dgrid_doctors.Columns)
            {
                if (column is DataGridViewImageColumn)
                {
<<<<<<< HEAD
                    ((DataGridViewImageColumn)column).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            ChangeColumnIndex("", 0, 22);

        }
        private void ChangeColumnIndex(string headerText, int newIndex, int newWidth)
        {
            DataGridViewColumn? column = dgrid_doctors.Columns.Cast<DataGridViewColumn>()
                                                .FirstOrDefault(c => c.HeaderText == headerText);

            if (column == null || newIndex < 0 || newIndex >= dgrid_doctors.Columns.Count)
            {
                // Invalid column or index
                return;
            }

            column.DisplayIndex = newIndex;
            column.Width = newWidth;
        }
=======
                    ((DataGridViewImageColumn)column).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }

        }

>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
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
<<<<<<< HEAD
            employee_Presenter.loadDoctorJoin();
=======
            employee_Presenter.loadDoctorJoin(dgrid_doctors);
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
        }

        private void s_Click(object sender, EventArgs e)
        {
            string docname = "Doctor";
<<<<<<< HEAD
            //var selectedEmployee = dgrid_employee.SelectedRows[0].Cells["PKEmployee"].Value;
            var selectedEmployee = dgrid_doctors.SelectedRows[0].DataBoundItem as Models.Employee;
            if (selectedEmployee != null)
            {
                var emp = new EmployeeRegistration(docname);
                emp.loadallCombobox();
                emp.putdataDoctor(this, selectedEmployee);
                emp.ShowDialog(this);
                employee_Presenter.loadDoctorJoin();
            }
=======
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
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
        }
    }
}
