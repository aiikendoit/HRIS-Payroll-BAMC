using FontAwesome.Sharp;
using HRIS.Class;
using HRIS.Forms.Userlogin;
using System.Net.Security;

namespace HRIS
{
    public partial class MainForm : Form
    {

        private IconButton currentbtn;
        private Form currentchildform;

        public MainForm()
        {
            InitializeComponent();
            currentbtn = new IconButton();
            currentchildform = new Form();
        }
        private void activatebutton(Object senderbtn, Color customcolor)
        {
            disablebutton();
            currentbtn = (IconButton)senderbtn;
            currentbtn.BackColor = Color.FromArgb(0, 127, 152);
            currentbtn.ForeColor = customcolor;
            currentbtn.IconColor = customcolor;
            //change form title name
            lbl_formtitle.Text = currentbtn.Tag as string;
            //change form icon
            icon_home.IconChar = currentbtn.IconChar;
            icon_home.IconColor = customcolor;
        }
        private void disablebutton()
        {
            if (currentbtn != null)
            {
                currentbtn.ForeColor = Color.White;
                currentbtn.IconColor = Color.White;
            }

        }

        private void Image_Logo_Click(object sender, EventArgs e)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            reset();
        }
        private void reset()
        {
            disablebutton();
            icon_home.IconChar = IconChar.Home;
            icon_home.IconColor = Color.White;
            lbl_formtitle.Text = "Home";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Userlogin userlogin = new Userlogin();
            userlogin.Show();
        }

        private void btn_dashboard_Click_1(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_dutyschedule_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_leaves_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_maintenance_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_reportmanager_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_audittrail_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }
    }
}