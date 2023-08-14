using HRIS.Class.Userlogin;
using HRIS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Userlogin
{
    public partial class UserConfirmation : Form
    {
        public bool islogin = false;
        public UserConfirmation()
        {
            InitializeComponent();
            string id = Properties.Settings.Default.employeeidno;
            txt_username.Text = id.ToString();
            txt_password.Select();
        }

        private void btn_login_Click(object sender, EventArgs e)
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
                islogin = true;
                this.Close();
            }
        }

        private void UserConfirmation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
