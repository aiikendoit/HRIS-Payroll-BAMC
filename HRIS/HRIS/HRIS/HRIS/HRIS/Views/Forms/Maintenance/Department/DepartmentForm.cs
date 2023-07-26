using HRIS.Class;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.Department;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.Department
{
    public partial class DepartmentForm : Form, IDeparmentView
    {
        private readonly department_Presenter department_Presenter;
        public DepartmentForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_department);
            department_Presenter = new department_Presenter(this);
            department_Presenter.LoadDepartment();


        }

        public void DisplayDepartment(List<Models.Department> departments)
        {
            dgrid_department.DataSource = departments;
            dgrid_department.Columns[0].HeaderText = "ID";
            if (dgrid_department.ColumnCount == 8)
            {
                //Remove unnecessary column
                dgrid_department.Columns.RemoveAt(7);
                dgrid_department.Columns.RemoveAt(6);
                dgrid_department.Columns.RemoveAt(4);
            }
            dgrid_department.AutoGenerateColumns = false;
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
