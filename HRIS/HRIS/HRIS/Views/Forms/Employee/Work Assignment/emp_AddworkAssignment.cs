using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Work_Assignment;
using HRIS.Views.Forms.Maintenance.Department;
using HRIS.Views.Forms.Maintenance.Positions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee.Work_Assignment
{
    public partial class emp_AddworkAssignment : Form, IDeparmentView, IPositionView, IWorkAssigmentView
    {
        private readonly department_Presenter department_presenter;
        private readonly position_Presenter position_presenter;
        private readonly workassignment_Presenter workassignment_presenter;
        private string emp_ID;
        public emp_AddworkAssignment(string employeeid)
        {
            InitializeComponent();
            department_presenter = new department_Presenter(this);
            position_presenter = new position_Presenter(this);
            workassignment_presenter = new workassignment_Presenter(this);
            department_presenter.LoadDepartment();
            emp_ID = employeeid;
        }

        public void DisplayDepartment(List<Department> departments)
        {
            txt_department.SelectedIndexChanged -= txt_department_SelectedIndexChanged;
            txt_department.DataSource = departments;
            txt_department.DisplayMember = "Description";
            txt_department.ValueMember = "PkDepartment";
            txt_department.SelectedIndexChanged += txt_department_SelectedIndexChanged;
        }

        public void DisplayPosition(List<Position> positions)
        {
            txt_position.DataSource = positions;
            txt_position.DisplayMember = "Description";
            txt_position.ValueMember = "PkPosition";
        }

        private void emp_AddworkAssignment_Load(object sender, EventArgs e)
        {

        }

        private void txt_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            int departmentid = Convert.ToInt32(txt_department.SelectedValue);
            position_presenter.LoadPositionwithWhere(departmentid);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add();
        }
        private void add()
        {
            try
            {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Workassignment
            {
                FkEmployee = Convert.ToInt32(emp_ID),
                FkDepartment = Convert.ToInt32(txt_department.SelectedValue),
                FkPosition = Convert.ToInt32(txt_position.SelectedValue),
                Jobdescription = txt_jobdescription.Text,
                Responsibilities = txt_reponsibilities.Text,
                Jobscope = txt_jobscope.Text,
                IsManager = checkBox_ishead.Checked,
                Startdate = txt_startdate.Value,
                Enddate = txt_enddate.Value,
                Createdby = createdby,
                FkSystemUser = id
            };
            workassignment_presenter.AddWorkAssignment(cv);
            MessageBox.Show("Added Successfully!");
            this.Close();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    // Display the inner exception details
                    MessageBox.Show($"An error occurred while saving the entity changes. Inner exception: {ex.InnerException.Message}");
                }
                else
                {
                    // Display the exception message if there is no inner exception
                    MessageBox.Show($"An error occurred while saving the entity changes. Exception: {ex.Message}");
                }
            }
        }

        public void DisplayWorkAssignment(List<Workassignment> workassignments)
        {

        }
    }
}
