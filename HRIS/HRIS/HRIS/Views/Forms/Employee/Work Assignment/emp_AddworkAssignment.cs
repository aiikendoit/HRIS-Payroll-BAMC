﻿using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Work_Assignment;
using HRIS.Views.Forms.Maintenance.Department;
using HRIS.Views.Forms.Maintenance.Positions;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
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
<<<<<<< HEAD
<<<<<<< HEAD
        private string emp_ID;
=======
        private readonly HrisContext _context;
        private string emp_ID;
        private int workassignmentid;
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
        private readonly HrisContext _context;
        private string emp_ID;
        private int workassignmentid;
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
        public emp_AddworkAssignment(string employeeid)
        {
            InitializeComponent();
            department_presenter = new department_Presenter(this);
            position_presenter = new position_Presenter(this);
            workassignment_presenter = new workassignment_Presenter(this);
<<<<<<< HEAD
<<<<<<< HEAD
            department_presenter.LoadDepartment();
            emp_ID = employeeid;
=======
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
            _context = new HrisContext();
            department_presenter.LoadDepartment();
            emp_ID = employeeid;
            label1.Text = employeeid;
<<<<<<< HEAD
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
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
<<<<<<< HEAD
<<<<<<< HEAD
            txt_position.DisplayMember = "Description";
=======
            txt_position.DisplayMember = "positionName";
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
            txt_position.DisplayMember = "positionName";
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
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
<<<<<<< HEAD
<<<<<<< HEAD
            add();
=======
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
            if (btn_save.Text == "Save")
            {
                add();
            }
            if (btn_save.Text == "Update")
            {
                update();
            }
            
           
<<<<<<< HEAD
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
        }
        private void add()
        {
            try
            {
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
                DateTime? dateTime = null;
                if (txt_enddate.Format != DateTimePickerFormat.Custom)
                {
                    dateTime = txt_enddate.Value;
                }
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
                    Enddate = dateTime,
                    Createdby = createdby,
                    FkSystemUser = id
                };
                workassignment_presenter.AddWorkAssignment(cv);
                MessageBox.Show("Added Successfully!");
                this.Close();
<<<<<<< HEAD
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
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
<<<<<<< HEAD
<<<<<<< HEAD

        public void DisplayWorkAssignment(List<Workassignment> workassignments)
        {

=======
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
        private void update()
        {
            try
            {
                var existingWorkAssignment = _context.Workassignments.Find(workassignmentid);
    
                DateTime? dateTime = null;
                if (txt_enddate.Format == DateTimePickerFormat.Short) { dateTime = txt_enddate.Value; }

                if (existingWorkAssignment != null)
                {
                    existingWorkAssignment.FkDepartment = Convert.ToInt32(txt_department.SelectedValue);
                    existingWorkAssignment.FkPosition = Convert.ToInt32(txt_position.SelectedValue);
                    existingWorkAssignment.FkEmployee = Convert.ToInt32(emp_ID);
                    existingWorkAssignment.Jobdescription = txt_jobdescription.Text;
                    existingWorkAssignment.Responsibilities = txt_reponsibilities.Text;
                    existingWorkAssignment.Jobscope = txt_jobscope.Text;
                    existingWorkAssignment.IsManager = checkBox_ishead.Checked;
                    existingWorkAssignment.Startdate = txt_startdate.Value;
                    existingWorkAssignment.Enddate = dateTime;
                    workassignment_presenter.UpdateWorkAssignment(existingWorkAssignment);
                  
                }
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
        public void putdata(int workass)
        {
            workassignmentid = workass;
            workassignment_presenter.loadWorkAssignmentWithWhere(workass);
            txt_enddate.Enabled = true;
            btn_save.Text = "Update";
        }

        public void DisplayWorkAssignment(List<Workassignment> workassignments)
        {
            try
            {
                if (workassignments != null && workassignments.Count > 0)
                {
                    Models.Workassignment wk = workassignments[0];
                    txt_department.SelectedValue = wk.FkDepartment;
                    txt_position.SelectedValue = wk.FkPosition;
                    txt_jobdescription.Text = wk.Jobdescription;
                    txt_reponsibilities.Text = wk.Responsibilities;
                    txt_jobscope.Text = wk.Jobscope;
                    checkBox_ishead.Checked = wk.IsManager ?? false;
                    
                    if (wk.Startdate == null)
                    {
                        txt_startdate.Format = DateTimePickerFormat.Custom;
                        txt_startdate.CustomFormat = " ";
                    } else
                    {
                        txt_startdate.Value = (DateTime)wk.Startdate;
                    }
                    if (wk.Enddate == null)
                    {
                        txt_enddate.Format = DateTimePickerFormat.Custom;
                        txt_enddate.CustomFormat = " ";
                    }
                    else
                    {
                        txt_enddate.Value = (DateTime)wk.Enddate;
                    }

                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"An error occurred while saving the entity changes. Inner exception: {ex.InnerException.Message}");
                }
                else
                {
                    MessageBox.Show($"An error occurred while saving the entity changes. Exception: {ex.Message}");
                }
            }
        }

        private void txt_enddate_ValueChanged(object sender, EventArgs e)
        {
            txt_enddate.Format = DateTimePickerFormat.Short;
<<<<<<< HEAD
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
        }
    }
}
