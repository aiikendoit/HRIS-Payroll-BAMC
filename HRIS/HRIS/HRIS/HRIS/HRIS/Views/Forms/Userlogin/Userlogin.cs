using HRIS.Class;
using HRIS.Class.Userlogin;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.User;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
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

        public void ClearFields()
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            //Check empty textbox
            if (UniversalStatic.IsEmpty(txt_username)) return;
            if (UniversalStatic.IsEmpty(txt_password)) return;
            if (UserloginClass.checklogin(txt_username.Text, txt_password.Text) == true)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
        }
        private void Userlogin_Load(object sender, EventArgs e)
        {
        }

        private void Userlogin_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                login();
                e.SuppressKeyPress = true;
            }
        }
    }
}
