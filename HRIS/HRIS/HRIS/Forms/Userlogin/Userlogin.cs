﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Userlogin
{
    public partial class Userlogin : Form
    {
        public Userlogin()
        {
            InitializeComponent();
            this.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void Userlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
