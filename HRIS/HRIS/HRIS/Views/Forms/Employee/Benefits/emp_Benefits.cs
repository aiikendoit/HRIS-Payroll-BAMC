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

namespace HRIS.Forms.Employee.Benefits
{
    public partial class emp_Benefits : Form
    {
        public emp_Benefits()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_benefits);
        }

        private void emp_Benefits_Load(object sender, EventArgs e)
        {

        }
    }
}