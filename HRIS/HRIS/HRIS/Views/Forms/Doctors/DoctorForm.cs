﻿using HRIS.Class;
using HRIS.Forms.Employee;
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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_doctors);
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string docname = "Doctor";
            EmployeeRegistration employeeForm = new EmployeeRegistration(docname);
            
            employeeForm.ShowDialog();
        }
    }
}