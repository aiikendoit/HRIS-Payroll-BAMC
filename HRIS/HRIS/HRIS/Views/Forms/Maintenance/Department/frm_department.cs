using HRIS.Forms.Maintenance.CivilStatus;
using HRIS.Forms.Maintenance.Department;
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

namespace HRIS.Views.Forms.Maintenance.Department
{
    public partial class frm_department : Form, IDeparmentView
    {
        private readonly department_Presenter department_Presenter;
        public bool isupdate = false;
        private DepartmentForm DepartmentForm;
        private Models.Department selectedDepartment;
        public frm_department()
        {
            InitializeComponent();
            department_Presenter = new department_Presenter(this);
            this.DepartmentForm = new DepartmentForm();
            this.selectedDepartment = new Models.Department();
        }
        public void putdata(DepartmentForm departmentForm, Models.Department department)
        {
            if (isupdate)
            {
                this.DepartmentForm = departmentForm;
                this.selectedDepartment = department;
                txt_department.Text = selectedDepartment.Description;
                checkBox_isactive.Checked = selectedDepartment.IsActive;
                btn_cancel.Select();
            }
            else
            {
                this.DepartmentForm = departmentForm;
                this.selectedDepartment = department;
                txt_department.Text = selectedDepartment.Description;
                checkBox_isactive.Checked = selectedDepartment.IsActive;
                btn_save.Visible = false;
                //disable control
                txt_department.Enabled = false;
                checkBox_isactive.Enabled = false;
            }

        }
        public void DisplayDepartment(List<Models.Department> departments)
        {
        }
        private void save()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Department
            {
                Description = txt_department.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            department_Presenter.AddDepartment(cv);
            this.Close();
        }
        private void update()
        {
            var selectedDept = selectedDepartment as Models.Department;

            selectedDept.Description = txt_department.Text;
            selectedDept.IsActive = checkBox_isactive.Checked;
            department_Presenter.UpdateDepartment(selectedDept);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isupdate)
            {
                update();
            }
            else
            {
                save();
            }
        }
    }
}
