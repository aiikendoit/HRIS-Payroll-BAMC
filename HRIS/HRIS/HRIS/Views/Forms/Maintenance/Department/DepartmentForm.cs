﻿using HRIS.Class;
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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_department);
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}